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
        public ActionResult VerificarAcceso(EntUserViewModel userViewModel)
        {

            string hashcode = LogHashing.Instance.Encrypt(userViewModel.Key);
            var redirectUrl = "";


            EntCuenta account = LogCuenta.Instancia.VerificarAcceso(userViewModel.UserName, hashcode);
            if (account != null)
            {
                Session["cuenta"] = account;

                if (account.Recep != null)
                {
                    redirectUrl = new UrlHelper(Request.RequestContext).Action("Index", "Home");
                    return Json(new { Usr = redirectUrl }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { Usr = account.Huesped.UserName }, JsonRequestBehavior.AllowGet);
                }

            }
            return Json(null, JsonRequestBehavior.AllowGet);
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