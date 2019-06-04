using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaLogica;

namespace CapaPresentacion.Controllers
{
    public class MenuExtranetController : Controller
    {
        // GET: MenuExtranet
        public ActionResult MenuExtranetIndex()
        {
            EntCuenta cuenta = (EntCuenta)Session["cuenta"];
            //ViewBag.Cuenta = cuenta.Admin.Nombre;
            return View();
        }
    }
}