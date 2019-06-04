using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaLogica;

namespace CapaPresentacion.Controllers
{
    public class MenuIntranetController : Controller
    {
        // GET: MenuIntranet
        
        public ActionResult MenuIntranetIndex()
        {
            EntCuenta cuenta = (EntCuenta)Session["cuenta"];
            //ViewBag.Cuenta = cuenta.Huesped.Nombre;
            return View();
        }
    }
}