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
        public void verificarSesion()
        {
            if (Session["cuenta"] != null)
            {
                EntCuenta cuenta = (EntCuenta)Session["cuenta"];
                ViewBag.Cuenta = cuenta;
            }
        }

        public ActionResult listarHabitaciones()
        {
            verificarSesion();

            List<EntHabitacion> lista = new List<EntHabitacion>();
            foreach (EntHabitacion habitacion in LogHabitacion.Instancia.ListarHabitaciones())
            {
                int ID = habitacion.Tipodehabitacion.TipodehabitacionID;
                List<EntServicioadicional> servs = LogServiciosAdicionales.Instancia.ObtenerServicios(ID);
                habitacion.Tipodehabitacion.ServiciosAdicionales = servs;
                lista.Add(habitacion);
            }
            ViewBag.lista = lista;
            return View(lista);
        }

        [HttpGet]
        public ActionResult insertarHabitacion()
        {
            verificarSesion();
            List<EntTipoDeHabitacion> listarTiposH = LogTipoDeHabitacion.Instancia.ListarTiposH();

            var listaTipos = new SelectList(listarTiposH, "TipodehabitacionID", "Nombretipodehabitacion");
            ViewBag.ListarTiposH = listaTipos;
            return View();
        }

        [HttpPost]
        public ActionResult insertarHabitacion(EntHabitacion habitacion, FormCollection frm)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View("insertarHabitacion");
            //}

            try
            {
                habitacion.Tipodehabitacion = new EntTipoDeHabitacion();
                habitacion.Tipodehabitacion.TipodehabitacionID = Convert.ToInt32(frm["cboTiposH"]);

                Boolean inserta = LogHabitacion.Instancia.InsertarHabitacion(habitacion);
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
            verificarSesion();
            EntHabitacion habitacion = new EntHabitacion(); 
            habitacion = LogHabitacion.Instancia.BuscarHabitacion(NumeroHabitacion);
            return View(habitacion);
        }

        [HttpPost]
        public ActionResult eliminarHabitacion(EntHabitacion habitacion)
        {
            try
            {
                Boolean delete = LogHabitacion.Instancia.EliminarHabitacion(habitacion);
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
            verificarSesion();
            List<EntTipoDeHabitacion> listarTiposH = LogTipoDeHabitacion.Instancia.ListarTiposH();

            var listaTipos = new SelectList(listarTiposH, "TipodehabitacionID", "Nombretipodehabitacion");
            ViewBag.ListarTiposH = listaTipos;

            EntHabitacion habitacion = new EntHabitacion();
            habitacion = LogHabitacion.Instancia.BuscarHabitacion(NumeroHabitacion);

            return View(habitacion);
        }

        [HttpPost]
        public ActionResult editarHabitacion(EntHabitacion habitacion, FormCollection frm)
        {
            try
            {
                habitacion.Tipodehabitacion = new EntTipoDeHabitacion();
                habitacion.Tipodehabitacion.TipodehabitacionID = Convert.ToInt32(frm["cboTiposH"]);

                Boolean edit = LogHabitacion.Instancia.EditarHabitacion(habitacion);
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