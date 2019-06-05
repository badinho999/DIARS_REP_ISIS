using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaLogica;

namespace CapaPresentacion.Controllers
{
    [AllowAnonymous]
    public class MenuController : Controller
    {
        // GET: Menu
        
        public void verificarSesion()
        {
            if (Session["cuenta"] != null)
            {
                EntCuenta cuenta = (EntCuenta)Session["cuenta"];
                ViewBag.Cuenta = cuenta;
            }
        }

        public ActionResult Inicio()
        {
            verificarSesion();
            return View();
        }
        public ActionResult About()
        {
            verificarSesion();
            return View();
        }
        public ActionResult Rooms()
        {
            verificarSesion();
            return View();
        }

        public ActionResult Contact()
        {
            verificarSesion();
            return View();
        }

    }
}