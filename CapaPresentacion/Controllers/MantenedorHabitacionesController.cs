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
            List<EntHabitacion> lista = new List<EntHabitacion>();
            foreach (EntHabitacion habitacion in LogHabitacion.Instancia.listarHabitaciones())
            {
                int ID = habitacion.Tipodehabitacion.TipodehabitacionID;
                List<EntServicioadicional> servs = LogServiciosAdicionales.Instancia.obtenerServicios(ID);
                habitacion.Tipodehabitacion.ServiciosAdicionales = servs;
                lista.Add(habitacion);
            }
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

        [HttpGet]
        public ActionResult eliminarHabitacion(string NumeroHabitacion)
        {
            EntHabitacion habitacion = new EntHabitacion(); 
            habitacion = LogHabitacion.Instancia.buscarHabitacion(NumeroHabitacion);
            return View(habitacion);
        }

        [HttpPost]
        public ActionResult eliminarHabitacion(EntHabitacion habitacion)
        {
            try
            {
                Boolean delete = LogHabitacion.Instancia.eliminarHabitacion(habitacion);
                if(delete)
                {
                    return RedirectToAction("listarHabitaciones");
                }
                else
                {
                    return View(habitacion);
                }
            }
            catch(ApplicationException ex)
            {
                return RedirectToAction("eliminarHabitacion", new { mesjException = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult editarHabitacion(string NumeroHabitacion)
        {
            List<EntTipoDeHabitacion> listarTiposH = LogTipoDeHabitacion.Instancia.listarTiposH();

            var listaTipos = new SelectList(listarTiposH, "TipodehabitacionID", "Nombretipodehabitacion");
            ViewBag.ListarTiposH = listaTipos;

            EntHabitacion habitacion = new EntHabitacion();
            habitacion = LogHabitacion.Instancia.buscarHabitacion(NumeroHabitacion);

            return View(habitacion);
        }

        [HttpPost]
        public ActionResult editarHabitacion(EntHabitacion habitacion, FormCollection frm)
        {
            try
            {
                habitacion.Tipodehabitacion = new EntTipoDeHabitacion();
                habitacion.Tipodehabitacion.TipodehabitacionID = Convert.ToInt32(frm["cboTiposH"]);

                Boolean edit = LogHabitacion.Instancia.editarHabitacion(habitacion);
                if (edit)
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
                return RedirectToAction("editarHabitacion", new { mesjException = ex.Message });
            }
        }

    }
}