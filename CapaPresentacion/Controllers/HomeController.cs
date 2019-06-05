using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaLogica;

namespace CapaPresentacion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            EntCuenta cuenta = new EntCuenta();
            string type = Convert.ToString(Session["cuenta"].GetType());
            cuenta = (EntCuenta)Session["cuenta"];
            ViewBag.Cuenta = cuenta;
            
            return View();
        }
    }
}