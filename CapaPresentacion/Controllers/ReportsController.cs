using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaLogica;

namespace CapaPresentacion.Controllers
{
    public class ReportsController : Controller
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
        // GET: Reports
        public ActionResult Reportes()
        {
            verificarSesion();
            return View();
        }

        public ActionResult ReportesHabitaciones() {
            verificarSesion();
            return View();
        }

        public ActionResult ReportesIngresosAlquiler()
        {
            verificarSesion();
            return View();
        }

        public ActionResult ReportesIngresosReserva()
        {
            verificarSesion();
            return View();
        }

        public ActionResult ClientesFrecuentes()
        {
            List<EntHuesped> lista = LogHuesped.Instancia.ClientesFrecuentes();
            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult HabitacionesMasOcupadas()
        {
            List<EntHabitacion> lista = LogHabitacion.Instancia.MasOcupadas();
            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult IngresosAlquiler()
        {
            List<EntComprobantedepagoalquiler> lista = LogComprobantePagoAlquiler.Instancia.IngresosAlquiler();
            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult IngresosReserva()
        {
            List<EntComprobantepagoreserva> lista = LogComprobanteReserva.Instancia.IngresosReserva();
            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }
    }
}