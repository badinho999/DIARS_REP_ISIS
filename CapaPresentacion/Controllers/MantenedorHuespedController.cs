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
        public EntCuenta user;
        // GET: MantenedorHuesped
        public void verificarSesion()
        {
            if (Session["cuenta"] != null)
            {
                EntCuenta cuenta = (EntCuenta)Session["cuenta"];
                ViewBag.Cuenta = cuenta;
            }
        }
        

        public ActionResult listarHuesped()
        {
            verificarSesion();
            List<EntHuesped> lista = LogHuesped.Instancia.listarHuesped();
            ViewBag.lista = lista;
            return View(lista);
        }

        [HttpGet]
        public ActionResult registrarCuenta()
        {
            verificarSesion();
            return View();
        }

        [HttpPost]
        public ActionResult registrarCuenta(EntCuenta cuenta)
        {
            if(!ModelState.IsValid)
            {
                return View("registrarCuenta");
            }
            try
            {
                Boolean registra = LogCuenta.Instancia.Registrarcuenta(cuenta);
                if (registra)
                {
                    return RedirectToAction("registrarHuesped", new { NombreUsuario = cuenta.NombreUsuario });
                }
                else
                {
                    return View(cuenta);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("registrarCuenta", new { mesjException = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult eliminarCuenta(string NombreUsuario)
        {
            verificarSesion();
            EntCuenta cuenta = new EntCuenta();
            cuenta = LogCuenta.Instancia.BuscarCuenta(NombreUsuario);
            return View(cuenta);
        }

        [HttpPost]
        public ActionResult eliminarCuenta(EntCuenta cuenta, FormCollection form)
        {
            try
            {
                Boolean delete = LogCuenta.Instancia.EliminarCuenta(cuenta);
                if (delete)
                {
                    return RedirectToAction("listarHuesped");
                }
                else
                {
                    return View(cuenta);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("registrarHuesped", new { mesjException = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult registrarHuesped(string NombreUsuario)
        {
            verificarSesion();
            ViewBag.NombreUsuario = NombreUsuario;
            EntHuesped huesped = new EntHuesped();
            huesped.Cuenta = LogCuenta.Instancia.BuscarCuenta(NombreUsuario);
            return View(huesped);
        }
        [HttpPost]
        public ActionResult registrarHuesped(EntHuesped huesped,FormCollection form)
        {
            
            try
            {
                huesped.Cuenta = new EntCuenta();
                foreach(string key in form.AllKeys)
                {
                    if (key.Equals("username"))
                    {
                        huesped.Cuenta.NombreUsuario = Convert.ToString(form[key]);
                    }
                }
                
                Boolean registra = LogHuesped.Instancia.registrarHuesped(huesped);
                if (registra)
                {
                    return RedirectToAction("listarHuesped");
                }
                else
                {
                    return View(huesped);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("registrarHuesped", new { mesjException = ex.Message });
            }
        }

        //Pendiente
        [HttpGet]
        public ActionResult editarHuesped(string Dni)
        {
            verificarSesion();
            EntHuesped huesped = new EntHuesped();
            huesped = LogHuesped.Instancia.BuscarHuesped(Dni);
            return View(huesped);
        }

        [HttpPost]
        public ActionResult editarHuesped(EntHuesped huesped)
        {
            try
            {
                Boolean edita = LogHuesped.Instancia.editarHuesped(huesped);
                if (edita)
                {
                    return RedirectToAction("listarHuesped");
                }
                else
                {
                    return View(huesped);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("editarHuesped", new { mesjException = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult eliminaHuesped(string Dni)
        {
            verificarSesion();
            EntHuesped huesped = new EntHuesped();
            huesped = LogHuesped.Instancia.BuscarHuesped(Dni);
            return View(huesped);
        }

        [HttpPost]
        public ActionResult eliminaHuesped(EntHuesped huesped)
        {
            try
            {
                Boolean delete = LogHuesped.Instancia.eliminarHuesped(huesped);
                if (delete)
                {
                    return RedirectToAction("listarHuesped");
                }
                else
                {
                    return View(huesped);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("eliminarHuesped", new { mesjException = ex.Message });
            }
        }
    }
}