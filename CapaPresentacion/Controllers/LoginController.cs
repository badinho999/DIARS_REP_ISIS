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
                Session["cuenta"] = cuenta;

                if(cuenta.Admin!=null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else if(cuenta.Huesped!=null)
                {
                    return RedirectToAction("Inicio", "Menu");
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

        public ActionResult CerrarSesion()
        {
            try
            {
                Session.RemoveAll();
                Session.Abandon();

                return RedirectToAction("Inicio", "Menu");
            }
            catch (Exception e)
            {
                ViewBag.mensaje = e.Message;
                return View();
            }
        }
    }
}