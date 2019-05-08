using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaLogica;
using CapaEntidades;

namespace CapaPresentacion.Controllers
{
    public class MantenedorHabitacionesController : Controller
    {
        // GET: MantenedorHabitaciones
        public ActionResult listarHabitaciones()
        {
            List<EntHabitacion> lista = LogHabitacion.Instancia.listarHabitaciones();
            ViewBag.lista = lista;
            return View(lista);
        }

        public ActionResult listarTiposH()
        {
            List<EntTipoDeHabitacion> lista = LogTipoDeHabitacion.Instancia.listarTiposH();
            ViewBag.lista = lista;
            return View(lista);
        }

        [HttpGet]
        public ActionResult insertarHabitacion()
        {
            List<EntTipoDeHabitacion> listarTiposH = LogTipoDeHabitacion.Instancia.listarTiposH();
            var listaTipos = new SelectList(listarTiposH, "TipodehabitacionID", "Nombretipodehabitacion");
            ViewBag.ListarTiposH = listaTipos;
            return View();
        }

        [HttpPost]
        public ActionResult insertarHabitacion(EntHabitacion habitacion, FormCollection frm)
        {
            try
            {
                habitacion.Tipodehabitacion = new EntTipoDeHabitacion();
                habitacion.Tipodehabitacion.TipodehabitacionID = Convert.ToInt32(frm["cboTiposH"]);

                Boolean inserta = LogHabitacion.Instancia.insertarHabitacion(habitacion);
                if (inserta)
                {
                    return RedirectToAction("listarHabitaciones");
                }
                else
                {
                    return View(habitacion);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("insertarHabitacion", new { mesjException = ex.Message });
            }
        }

    }
}