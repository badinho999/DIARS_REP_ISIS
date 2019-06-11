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

        public EntHabitacion buscarHabitacionRepetida(List<EntHabitacion> listaHabitaciones, string numeroDeHabitacion)
        {
            EntHabitacion habitacionRet = new EntHabitacion();
            bool encontrado = false;

            foreach (EntHabitacion habitacion in listaHabitaciones)
            {
                if (habitacion.NumeroHabitacion.Equals(numeroDeHabitacion))
                {
                    encontrado = true;
                    habitacionRet = habitacion;
                }
                else
                {
                    encontrado = false;
                }
            }

            if (encontrado)
            {
                return habitacionRet;
            }
            else
            {
                return null;
            }
        }

        public void agregarAlista(List<EntHabitacion> listaHabitaciones, string numeroDeHabitacion)
        {
            if (buscarHabitacionRepetida(listaHabitaciones, numeroDeHabitacion) == null)
                listaHabitaciones.Add(LogHabitacion.Instancia.buscarHabitacion(numeroDeHabitacion));
        }

        public void eliminarHabitacionNoDisponible(List<EntHabitacion> listaHabitacionesDisponibles, List<EntHabitacion> listaHabitacionesNoDisponibles)
        {

            foreach (EntHabitacion habitacion in listaHabitacionesNoDisponibles)
            {
                listaHabitacionesDisponibles.RemoveAll(x => x.NumeroHabitacion == habitacion.NumeroHabitacion);
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

            List<EntHabitacion> listaHabitacionesDisponibles = new List<EntHabitacion>();
            List<EntHabitacion> listaHabitacionesNoDisponibles = new List<EntHabitacion>();

            DateTime fechaIngreso = Convert.ToDateTime(_fechaIngreso,CultureInfo.InvariantCulture),
            fechaSalida = Convert.ToDateTime(_fechaSalida,CultureInfo.InvariantCulture);
            bool esMayor = false;

            try
            {
                List<EntReserva> reservas;

                reservas = LogReserva.Instancia.ListarHabitacionesDisponibles(cantidadPersonas);

                foreach (EntReserva reserva in reservas)
                {
                    DateTime fechaIngresoAux, fechaSalidaAux;

                    fechaIngresoAux = Convert.ToDateTime(reserva.FechadeIngreso);
                    fechaSalidaAux = Convert.ToDateTime(reserva.FechadeSalida);

                    if (DateTime.Compare(fechaIngreso, fechaSalidaAux) > 0)
                    {
                        esMayor = true;
                    }
                    else if (DateTime.Compare(fechaIngreso, fechaIngresoAux) < 0)
                    {
                        esMayor = false;
                    }

                    if (esMayor)
                    {
                        agregarAlista(listaHabitacionesDisponibles, reserva.Habitacion.NumeroHabitacion);
                    }
                    else
                    {
                        if (DateTime.Compare(fechaSalida, fechaIngresoAux) < 0)
                        {
                            agregarAlista(listaHabitacionesDisponibles, reserva.Habitacion.NumeroHabitacion);
                        }
                        else
                        {
                            agregarAlista(listaHabitacionesNoDisponibles, reserva.Habitacion.NumeroHabitacion);
                        }
                    }
                }

                eliminarHabitacionNoDisponible(listaHabitacionesDisponibles, listaHabitacionesNoDisponibles);

                List<EntHabitacion> lista = new List<EntHabitacion>();
                foreach (EntHabitacion habitacion in listaHabitacionesDisponibles)
                {
                    int ID = habitacion.Tipodehabitacion.TipodehabitacionID;
                    List<EntServicioadicional> servs = LogServiciosAdicionales.Instancia.obtenerServicios(ID);
                    habitacion.Tipodehabitacion.ServiciosAdicionales = servs;
                    lista.Add(habitacion);
                }

                ViewBag.FechaReserva = DateTime.Today.ToString("d", culture);
                ViewBag.FechaIngreso = _fechaIngreso;
                ViewBag.FechaSalida = _fechaSalida;
                ViewBag.CantidadAdultos = cantidadAdultos;
                ViewBag.CantidadKids = cantidadKids;

                ViewBag.lista = lista;
                return View(lista);
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
            ViewBag.FechaReserva = fechaReserva;
            ViewBag.FechaIngreso = fechaIngreso;
            ViewBag.FechaSalida = fechaSalida;
            ViewBag.CantidadAdultos = cantidadAdultos;
            ViewBag.CantidadKids = cantidadKids;

            EntHabitacion habitacion = new EntHabitacion();
            habitacion = LogHabitacion.Instancia.buscarHabitacion(numeroHabitacion);

            return View(habitacion);
        }

        [HttpPost]
        public ActionResult RealizarReserva(EntHabitacion habitacion, FormCollection frm)
        {
            verificarSesion();

            EntCuenta cuenta = (EntCuenta)Session["cuenta"];

            EntHuesped huesped = cuenta.Huesped;

            EntReserva reserva = new EntReserva();
            reserva.Fechadereserva = frm["txtFechaReserva"];
            reserva.FechadeIngreso = frm["txtFechaIngreso"];
            reserva.FechadeSalida = frm["txtFechaSalida"];

            reserva.CantidaAdultos = int.Parse(frm["txtCantidadAdultos"]);

            reserva.CantidadKids = int.Parse(frm["txtCantidadKids"]);

            reserva.Habitacion = habitacion;
            reserva.Huesped = huesped;

            try
            {
                Boolean alquila = LogReserva.Instancia.RealizarReserva(reserva);
                if (alquila)
                {
                    return RedirectToAction("Inicio", "Menu");
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