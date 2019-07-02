using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaLogica;

namespace CapaPresentacion.Controllers
{
    public class RealizarAlquilerController : Controller
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

        // GET: RealizarAlquiler
        [HttpGet]
        public ActionResult AlquilerMenu(string dni)
        {
            verificarSesion();

            EntHuesped huesped = new EntHuesped
            {
                Dni = dni
            };

            return View(huesped);
        }

        public ActionResult HabitacionesDisponibles(FormCollection frm)
        {
            verificarSesion();
            string cultureName = "en-US";
            var culture = new CultureInfo(cultureName);
            string dni = Convert.ToString(frm["txtdni"]);

            string _fechaIngreso = DateTime.Today.ToString("d", culture);
            string _fechaSalida = frm["txtCheckOut"];

            int cantidadAdultos = int.Parse(frm["selectAdultos"]);
            int cantidadKids = int.Parse(frm["selectKids"]);
            int cantidadPersonas = cantidadAdultos + cantidadKids;

            DateTime fechaIngreso = Convert.ToDateTime(_fechaIngreso, CultureInfo.InvariantCulture),
            fechaSalida = Convert.ToDateTime(_fechaSalida, CultureInfo.InvariantCulture);

            try
            {
                string fechaIngresoAlquiler = DateTime.Today.Date.ToString("yyyy-MM-dd");

                TimeSpan diferencia = fechaSalida - fechaIngreso;
                TimeSpan diferenciaSalida = fechaSalida - DateTime.Today.Date;

                EntHuesped huesped = LogHuesped.Instancia.BuscarHuesped(dni);

                EntAlquiler alquiler = new EntAlquiler
                {
                    FechadeIngreso = _fechaIngreso,
                    FechadeSalida = _fechaSalida,
                    CantidaAdultos = cantidadAdultos,
                    CantidadKids = cantidadKids,
                    Huesped = huesped
                };

                if(diferenciaSalida.Days < 0)
                {
                    EntAlquilerViewModel ViewModelError = new EntAlquilerViewModel
                    {
                        Alquiler = alquiler,
                        ErrorID = 0
                    };
                    return View(ViewModelError);
                }

                if (diferencia.Days > 28)
                {
                    EntAlquilerViewModel ViewModelError = new EntAlquilerViewModel
                    {
                        Alquiler = alquiler,
                        ErrorID = 1
                    };
                    return View(ViewModelError);

                }
                if (cantidadAdultos == 0)
                {
                    EntAlquilerViewModel ViewModelError = new EntAlquilerViewModel
                    {
                        Alquiler = alquiler,
                        ErrorID = 2
                    };
                    return View(ViewModelError);

                }
                if (cantidadPersonas > 6)
                {
                    EntAlquilerViewModel ViewModelError = new EntAlquilerViewModel
                    {
                        Alquiler = alquiler,
                        ErrorID = 3
                    };
                    return View(ViewModelError);
                }

                List<EntHabitacion> listaHabitacionesDisponibles = LogAlquiler.Instancia.ListarHabitacionesDisponibles(cantidadPersonas,fechaIngresoAlquiler,fechaSalida);

                List<EntHabitacion> lista = new List<EntHabitacion>();
                foreach (EntHabitacion habitacion in listaHabitacionesDisponibles)
                {
                    int ID = habitacion.Tipodehabitacion.TipodehabitacionID;
                    List<EntServicioadicional> servs = LogServiciosAdicionales.Instancia.ObtenerServicios(ID);
                    habitacion.Tipodehabitacion.ServiciosAdicionales = servs;
                    lista.Add(habitacion);
                }


                EntAlquilerViewModel ViewModel = new EntAlquilerViewModel
                {
                    Alquiler = alquiler,
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
        public ActionResult ProcesarAlquiler(int reservaID)
        {
            verificarSesion();
            EntReserva reserva = LogReserva.Instancia.BuscarReserva(reservaID);

            ((EntCuenta)Session["cuenta"]).ReservaID = reserva.ReservaID;
                
            EntAlquiler alquiler = new EntAlquiler
            {
                FechadeIngreso = reserva.FechadeIngreso,
                FechadeSalida = reserva.FechadeSalida,
                CantidaAdultos = reserva.CantidaAdultos,
                CantidadKids = reserva.CantidadKids,
                Habitacion = reserva.Habitacion,
                Huesped = reserva.Huesped

            };

            return View(alquiler);
        }
        [HttpPost]
        public ActionResult ProcesarAlquiler(EntHabitacion habitacion, FormCollection frm)
        {
            verificarSesion();
            string dni = frm["txtDni"];
            string numeroHabitacion = frm["txtNumeroHabitacion"];
            double precio = double.Parse(frm["txtprecio"]);

            EntHuesped huesped = LogHuesped.Instancia.BuscarHuesped(dni);

            habitacion = new EntHabitacion
            {
                NumeroHabitacion = numeroHabitacion
            };

            Random rdn = new Random();

            EntAlquiler alquiler = new EntAlquiler
            {
                AlquilerID = rdn.Next(20,int.MaxValue),
                FechadeIngreso = frm["txtFechaIngreso"],
                FechadeSalida = frm["txtFechaSalida"],

                CantidaAdultos = int.Parse(frm["txtCantidadAdultos"]),

                CantidadKids = int.Parse(frm["txtCantidadKids"]),

                Habitacion = habitacion,
                Huesped = huesped
            };

            try
            {
                Boolean alquila = LogAlquiler.Instancia.RealizarAlquiler(alquiler);
                if (alquila)
                {
                    EntComprobantedepagoalquiler ca = new EntComprobantedepagoalquiler
                    {
                        Alquiler = alquiler,
                        Monto = precio,
                        NumeroSerie = rdn.Next(10001, int.MaxValue)
                    };

                    Boolean generarCPAlquiler = LogComprobantePagoAlquiler.Instancia.GenerarComprobanteAlquiler(ca);

                    int reservaID = ((EntCuenta)Session["cuenta"]).ReservaID;

                    bool cambiaEstado = LogReserva.Instancia.AnularReserva(reservaID);

                    if(cambiaEstado)
                    {
                        ((EntCuenta)Session["cuenta"]).ReservaID = 0;
                    }

                    return RedirectToAction("AlquilerMenu", "RealizarAlquiler", new { dni = huesped.Dni });
                }
                else
                {
                    return View(alquiler);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("RealizarAlquiler", new { mesjException = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult RealizarAlquiler(string numeroHabitacion,string dni,string fechaIngreso,string fechaSalida, int cantidadAdultos,int cantidadKids)
        {
            verificarSesion();
            EntHabitacion habitacion = new EntHabitacion();
            habitacion = LogHabitacion.Instancia.BuscarHabitacion(numeroHabitacion);
            EntHuesped huesped = new EntHuesped
            {
                Dni = dni
            };


            EntAlquiler alquiler = new EntAlquiler
            {
                FechadeIngreso = fechaIngreso,
                FechadeSalida = fechaSalida,
                CantidaAdultos = cantidadAdultos,
                CantidadKids = cantidadKids,
                Habitacion = habitacion,
                Huesped = huesped
                
            };
            
            return View(alquiler);
        }
        [HttpPost]
        public ActionResult RealizarAlquiler(EntHabitacion habitacion,FormCollection frm)
        {
            verificarSesion();
            string dni = frm["txtDni"];

            string numeroHabitacion = frm["txtNumeroHabitacion"];

            double precio = double.Parse(frm["txtprecio"]);

            EntHuesped huesped = LogHuesped.Instancia.BuscarHuesped(dni);

            habitacion = new EntHabitacion
            {
                NumeroHabitacion = numeroHabitacion
            };

            Random rdn = new Random();

            EntAlquiler alquiler = new EntAlquiler
            {
                AlquilerID = rdn.Next(20, int.MaxValue),
                FechadeIngreso = frm["txtFechaIngreso"],
                FechadeSalida = frm["txtFechaSalida"],

                CantidaAdultos = int.Parse(frm["txtCantidadAdultos"]),

                CantidadKids = int.Parse(frm["txtCantidadKids"]),

                Habitacion = habitacion,
                Huesped = huesped
            };

            try
            {
                Boolean alquila = LogAlquiler.Instancia.RealizarAlquiler(alquiler);
                if (alquila)
                {
                    EntComprobantedepagoalquiler ca = new EntComprobantedepagoalquiler
                    {
                        Alquiler = alquiler,
                        Monto = precio,
                        NumeroSerie = rdn.Next(10001, int.MaxValue)
                    };

                    Boolean generarCPAlquiler = LogComprobantePagoAlquiler.Instancia.GenerarComprobanteAlquiler(ca);

                    return RedirectToAction("AlquilerMenu", "RealizarAlquiler", new { dni = huesped.Dni });
                }
                else
                {
                    return View(alquiler);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("RealizarAlquiler", new { mesjException = ex.Message });
            }
        }
        
        public ActionResult BuscarReservaHuesped()
        {
            verificarSesion();
            EntHuesped huesped = new EntHuesped();
            return View(huesped);
        }

        [HttpPost]
        public ActionResult ReservasDeHuesped(EntHuesped huesped)
        {
            verificarSesion();
            EntHuesped h = LogHuesped.Instancia.BuscarHuesped(huesped.Dni);

            if(h==null)
            {
                return RedirectToAction("BuscarReservaHuesped", "RealizarAlquiler");
            }

            List<EntReserva> lista = LogReserva.Instancia.BuscarReservaDeHueped(h.Dni);

            if(lista.Count==0)
            {
                return RedirectToAction("AlquilerMenu", "RealizarAlquiler",new { dni = h.Dni });
            }

            return View(lista);
        }

    }
}