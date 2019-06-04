using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaLogica;

namespace CapaPresentacion.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult VerificarAcceso()
        {
            return View();
        }
        [HttpPost]
        public ActionResult VerificarAcceso(FormCollection frm)
        {
            try
            {
                string txtNombreUsuario = frm["txtNombreUsuario"];
                string txtPassword = frm["txtPassword"];
                EntCuenta cuenta = LogCuenta.Instancia.VerificarAcceso(txtNombreUsuario, txtPassword);
                Session["usuario"] = cuenta;

                if(cuenta.Admin!=null)
                {
                    return RedirectToAction("MenuIntranetIndex", "MenuIntranet");
                }
                else if(cuenta.Huesped!=null)
                {
                    return RedirectToAction("MenuExtranetIndex", "MenuExtranet");
                }
                else
                {
                    return RedirectToAction("VerificarAcceso");
                }
            }
            catch (ApplicationException e)
            {
                ViewBag.mensaje = e.Message;
                return View();
            }
            catch (Exception e)
            {
                ViewBag.mensaje = e.Message;
                return View();
            }
        }
    }
}