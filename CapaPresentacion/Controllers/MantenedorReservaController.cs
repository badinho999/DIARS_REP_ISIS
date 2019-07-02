using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class MantenedorReservaController : Controller
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

        public ActionResult BuscarReserva()
        {
            verificarSesion();
            EntReserva reserva = new EntReserva();
            return View(reserva);
        }

        [HttpPost]
        public ActionResult EditarReserva(EntReserva reserva)
        {
            verificarSesion();

            EntReserva re = LogReserva.Instancia.BuscarReserva(reserva.ReservaID);

            if(re==null)
            {
                return RedirectToAction("BuscarReserva", "MantenedorReserva");
            }

            else
            {
                return View(re);
            }
        }

        [HttpPost]
        public ActionResult CambiarFechas(EntReserva reserva,FormCollection frm)
        {
            verificarSesion();

            string fechaIngreso = Convert.ToString(frm["txtFechaIngreso"]);
            string fechaSalida = Convert.ToString(frm["txtFechaSalida"]);

            try
            {
                Boolean edit = LogReserva.Instancia.ActivarReserva(reserva.ReservaID,fechaIngreso,fechaSalida);
                if (edit)
                {
                    return RedirectToAction("BuscarReserva");
                }
                else
                {
                    return View(reserva);
                }
            }
            catch (ApplicationException e)
            {

                return RedirectToAction("CambiarFechas", new { mesjException = e.Message });
            }
        }
    }
}