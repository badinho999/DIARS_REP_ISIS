using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaLogica;
using CapaEntidades;

namespace CapaPresentacion.Controllers
{
    public class MantenedorHuespedController : Controller
    {
        // GET: MantenedorHuesped
        public ActionResult listarHuesped()
        {
            List<EntHuesped> lista = LogHuesped.Instancia.listarHuesped();
            ViewBag.lista = lista;
            return View(lista);
        }
    }
}