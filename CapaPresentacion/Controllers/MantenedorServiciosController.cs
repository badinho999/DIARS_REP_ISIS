using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaLogica;
using CapaEntidades;

namespace CapaPresentacion.Controllers
{
    public class MantenedorServiciosController : Controller
    {
        public void verificarSesion()
        {
            if (Session["cuenta"] != null)
            {
                EntCuenta cuenta = (EntCuenta)Session["cuenta"];
                ViewBag.Cuenta = cuenta;
            }
        }

        public ActionResult listarServicios()
        {
            verificarSesion();
            List<EntServicioadicional> lista = LogServiciosAdicionales.Instancia.listarServicios();
            ViewBag.lista = lista;
            return View(lista);
        }

        [HttpGet]
        public ActionResult insertarServicio()
        {
            verificarSesion();
            return View();
        }

        [HttpPost]
        public ActionResult insertarServicio(EntServicioadicional servicioadicional)
        {
            try
            {
                Boolean insert = LogServiciosAdicionales.Instancia.insertarServicio(servicioadicional);
                if (insert)
                {
                    return RedirectToAction("listarServicios");
                }
                else
                {
                    return View(servicioadicional);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("insertarServicio", new { mesjException = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult editarServicio(int ServicioID)
        {
            verificarSesion();
            EntServicioadicional servicioadicional = new EntServicioadicional();
            servicioadicional = LogServiciosAdicionales.Instancia.buscarServicio(ServicioID);
            return View(servicioadicional);
        }

        [HttpPost]
        public ActionResult editarServicio(EntServicioadicional servicioadicional)
        {
            try
            {
                Boolean edita = LogServiciosAdicionales.Instancia.editarServicio(servicioadicional);
                if (edita)
                {
                    return RedirectToAction("listarServicios");
                }
                else
                {
                    return View(servicioadicional);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("editarServicio", new { mesjException = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult eliminarServicio(int ServicioID)
        {
            verificarSesion();
            EntServicioadicional servicioadicional = new EntServicioadicional();
            servicioadicional = LogServiciosAdicionales.Instancia.buscarServicio(ServicioID);
            return View(servicioadicional);
        }

        [HttpPost]
        public ActionResult eliminarServicio(EntServicioadicional servicioadicional)
        {
            try
            {
                Boolean delete = LogServiciosAdicionales.Instancia.eliminarServicio(servicioadicional);
                if (delete)
                {
                    return RedirectToAction("listarServicios");
                }
                else
                {
                    return View(servicioadicional);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("eliminarServicio", new { mesjException = ex.Message });
            }
        }
    }
}