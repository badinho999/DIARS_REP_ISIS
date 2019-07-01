using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class AnularReservaController : Controller
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

        public ActionResult MisReservas()
        {
            verificarSesion();
            EntCuenta cuenta= (EntCuenta)Session["cuenta"];
            EntHuesped huesped = cuenta.Huesped;
            List<EntReserva> lista = LogReserva.Instancia.MisReservas(huesped.Dni);

            if (lista.Count == 0)
            {
                EntReservaViewModel ViewModelError = new EntReservaViewModel
                {
                    ErrorID = 0
                };
                return View(ViewModelError);
            }

            EntReservaViewModel ViewModel = new EntReservaViewModel
            {
                ErrorID = -1,
                Reservas = lista
            };

            return View(ViewModel);

        }
    }
}