using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaLogica;
using CapaEntidades;
using System.Globalization;

namespace CapaPresentacion.Controllers
{
    public class RealizarReservaController : Controller
    {
        #region funciones

        public void verificarSesion()
        {
            if (Session["cuenta"] != null)
            {
                EntCuenta cuenta = (EntCuenta)Session["cuenta"];
                ViewBag.Cuenta = cuenta;
            }
        }

        #endregion funciones

        // GET: RealizarReserva
        public ActionResult HabitacionesDisponibles(FormCollection frm)
        {
            verificarSesion();

            string cultureName = "en-US";
            var culture = new CultureInfo(cultureName);

            string _fechaIngreso = frm["txtCheckIn"];
            string _fechaSalida = frm["txtCheckOut"];

            int cantidadAdultos = int.Parse(frm["selectAdultos"]);
            int cantidadKids = int.Parse(frm["selectKids"]);
            int cantidadPersonas = cantidadAdultos + cantidadKids;

            DateTime fechaIngreso = Convert.ToDateTime(_fechaIngreso,CultureInfo.InvariantCulture),
            fechaSalida = Convert.ToDateTime(_fechaSalida,CultureInfo.InvariantCulture);

            try
            {
                TimeSpan diferencia = fechaSalida - fechaIngreso;

                TimeSpan diferenciaIngreso = fechaIngreso - DateTime.Today.Date;
                TimeSpan diferenciaSalida = fechaSalida - DateTime.Today.Date;

                if (diferenciaIngreso.Days < 0 || diferenciaSalida.Days < 0)
                {
                    EntReservaViewModel ViewModelError = new EntReservaViewModel
                    {
                        ErrorID = 0
                    };
                    return View(ViewModelError);
                }

                if (diferencia.Days > 28)
                {
                    EntReservaViewModel ViewModelError = new EntReservaViewModel
                    {
                        ErrorID = 1
                    };
                    return View(ViewModelError);
                    
                }
                if (cantidadAdultos == 0)
                {
                    EntReservaViewModel ViewModelError = new EntReservaViewModel
                    {
                        ErrorID = 2
                    };
                    return View(ViewModelError);
                    
                }
                if(cantidadPersonas>6)
                {
                    EntReservaViewModel ViewModelError = new EntReservaViewModel
                    {
                        ErrorID = 3
                    };
                    return View(ViewModelError);
                }

                List<EntHabitacion> listaHabitacionesDisponibles = LogReserva.Instancia.ListarHabitacionesDisponibles(cantidadPersonas,fechaIngreso, fechaSalida);

                List<EntHabitacion> lista = new List<EntHabitacion>();
                foreach (EntHabitacion habitacion in listaHabitacionesDisponibles)
                {
                    int ID = habitacion.Tipodehabitacion.TipodehabitacionID;
                    List<EntServicioadicional> servs = LogServiciosAdicionales.Instancia.ObtenerServicios(ID);
                    habitacion.Tipodehabitacion.ServiciosAdicionales = servs;
                    lista.Add(habitacion);
                    
                }

                EntReserva reserva = new EntReserva
                {
                    Fechadereserva = DateTime.Today.ToString("d", culture),
                    FechadeIngreso = _fechaIngreso,
                    FechadeSalida = _fechaSalida,
                    CantidaAdultos = cantidadAdultos,
                    CantidadKids = cantidadKids

                };

                EntReservaViewModel ViewModel = new EntReservaViewModel
                {
                    Reserva = reserva,
                    Habitaciones = lista,
                    ErrorID = -1
                };
                

                return View(ViewModel);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        [HttpGet]
        public ActionResult RealizarReserva(string numeroHabitacion,string fechaReserva,string fechaIngreso, string fechaSalida, int cantidadAdultos, int cantidadKids)
        {
            verificarSesion();
            

            EntHabitacion habitacion = new EntHabitacion();
            habitacion = LogHabitacion.Instancia.BuscarHabitacion(numeroHabitacion);

            EntReserva reserva = new EntReserva
            {
                Fechadereserva = fechaReserva,
                FechadeIngreso = fechaIngreso,
                FechadeSalida = fechaSalida,
                CantidaAdultos = cantidadAdultos,
                CantidadKids = cantidadKids,
                Habitacion = habitacion
            };

            return View(reserva);
        }

        [HttpPost]
        public ActionResult RealizarReserva(EntHabitacion habitacion, FormCollection frm)
        {
            verificarSesion();

            EntCuenta cuenta = (EntCuenta)Session["cuenta"];

            EntHuesped huesped = cuenta.Huesped;

            Random rdn = new Random();

            EntReserva reserva = new EntReserva
            {
                ReservaID = rdn.Next(20,int.MaxValue),
                Fechadereserva = frm["txtFechaReserva"],
                FechadeIngreso = frm["txtFechaIngreso"],
                FechadeSalida = frm["txtFechaSalida"],

                CantidaAdultos = int.Parse(frm["txtCantidadAdultos"]),

                CantidadKids = int.Parse(frm["txtCantidadKids"]),

                Habitacion = habitacion,
                Huesped = huesped
            };

            try
            {
                Boolean alquila = LogReserva.Instancia.RealizarReserva(reserva);
                if (alquila)
                {
                    double precio = double.Parse(frm["precio"]);
                    ((EntCuenta)Session["cuenta"]).ReservaID = reserva.ReservaID;
                    ((EntCuenta)Session["cuenta"]).Monto = precio;

                    return RedirectToAction("CreatePayment", "Paypal",new { id = reserva.ReservaID, monto = precio, tax = 0, shipping = 0 });
                }   
                else
                {
                    return View(reserva);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("RealizarReserva", new { mesjException = ex.Message });
            }
        }

    }
}