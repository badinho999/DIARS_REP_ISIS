﻿using System;
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

        [HttpGet]
        public ActionResult registrarHuesped()
        {
            return View();
        }
        [HttpPost]
        public ActionResult registrarHuesped(EntHuesped huesped)
        {
            try
            {
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

        [HttpGet]
        public ActionResult editarHuesped(string Dni)
        {
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