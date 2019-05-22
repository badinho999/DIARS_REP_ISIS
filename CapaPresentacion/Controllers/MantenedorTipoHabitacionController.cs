using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaLogica;

namespace CapaPresentacion.Controllers
{
    public class MantenedorTipoHabitacionController : Controller
    {
        // GET: TipoHabitacion
        public ActionResult listarTiposH()
        {
            List<EntTipoDeHabitacion> lista = new List<EntTipoDeHabitacion>();
            foreach (EntTipoDeHabitacion thabitacion in LogTipoDeHabitacion.Instancia.listarTiposH())
            {
                int ID = thabitacion.TipodehabitacionID;
                List<EntServicioadicional> servs = LogServiciosAdicionales.Instancia.obtenerServicios(ID);
                thabitacion.ServiciosAdicionales = servs;
                lista.Add(thabitacion);
            }
            ViewBag.lista = lista;
            return View(lista);
        }

        [HttpGet]
        public ActionResult insertarTipoHabitacion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult insertarTipoHabitacion(EntTipoDeHabitacion tipoHabitacion)
        {
            try
            {
                Boolean inserta = LogTipoDeHabitacion.Instancia.ingresarTipoH(tipoHabitacion);
                if (inserta)
                {
                        return RedirectToAction("listarTiposH");
                }
                else
                {
                    return View(tipoHabitacion);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("insertarTipoHabitacion", new { mesjException = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult editarTipoH(int TipodehabitacionID)
        {
            EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion();
            tipoDeHabitacion = LogTipoDeHabitacion.Instancia.buscarTipoH(TipodehabitacionID);

            return View(tipoDeHabitacion);
        }

        [HttpPost]
        public ActionResult editarTipoH(EntTipoDeHabitacion tipoHabitacion)
        {
            try
            {
                Boolean edit = LogTipoDeHabitacion.Instancia.editarTipoH(tipoHabitacion);
                if (edit)
                {
                    return RedirectToAction("listarTiposH");
                }
                else
                {
                    return View(tipoHabitacion);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("editarTipoH", new { mesjException = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult eliminarTipoH(int TipodehabitacionID)
        {
            EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion();
            tipoDeHabitacion = LogTipoDeHabitacion.Instancia.buscarTipoH(TipodehabitacionID);

            return View(tipoDeHabitacion);
        }

        [HttpPost]
        public ActionResult eliminarTipoH(EntTipoDeHabitacion tipoHabitacion)
        {
            try
            {
                Boolean delete = LogTipoDeHabitacion.Instancia.eliminarTipoH(tipoHabitacion);
                if (delete)
                {
                    return RedirectToAction("listarTiposH");
                }
                else
                {
                    return View(tipoHabitacion);
                }
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("eliminarTipoH", new { mesjException = ex.Message });
            }
        }

        //Agregar servicios
        [HttpGet]
        public ActionResult agregarServicios(int TipodehabitacionID)
        {
            List<EntServicioadicional> listarServicios = LogServiciosAdicionales.Instancia.listarServicios();

            var listaServicios = new MultiSelectList(listarServicios, "ServicioID", "NombreDeServicio");
            ViewBag.listaServicios = listaServicios;

            EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion();
            tipoDeHabitacion = LogTipoDeHabitacion.Instancia.buscarTipoH(TipodehabitacionID);

            return View(tipoDeHabitacion);
        }

        [HttpPost]
        public ActionResult agregarServicios(EntTipoDeHabitacion tipoHabitacion)
        {
            try
            {
                if (tipoHabitacion.SelectedIds != null)
                {
                    foreach (int id in tipoHabitacion.SelectedIds)
                    {
                        EntServicioadicional servicioadicional = new EntServicioadicional();
                        servicioadicional.ServicioID = id;

                        Boolean isertServ = LogTipoDeHabitacion.Instancia.TipoHServicio(tipoHabitacion, servicioadicional);
                    }
                }

                return RedirectToAction("listarTiposH");
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("insertarTipoHabitacion", new { mesjException = ex.Message });
            }
        }
        //Agregar servicios

        //Eliminar Servicios
        [HttpGet]
        public ActionResult eliminarServicios(int TipodehabitacionID)
        {
            List<EntServicioadicional> listarServicios = LogServiciosAdicionales.Instancia.obtenerServicios(TipodehabitacionID);

            var listaServicios = new MultiSelectList(listarServicios, "ServicioID", "NombreDeServicio");
            ViewBag.listaServicios = listaServicios;

            EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion();
            tipoDeHabitacion = LogTipoDeHabitacion.Instancia.buscarTipoH(TipodehabitacionID);

            return View(tipoDeHabitacion);
        }

        [HttpPost]
        public ActionResult eliminarServicios(EntTipoDeHabitacion tipoHabitacion)
        {
            try
            {
                if (tipoHabitacion.SelectedIds != null)
                {
                    foreach (int id in tipoHabitacion.SelectedIds)
                    {
                        EntServicioadicional servicioadicional = new EntServicioadicional();
                        servicioadicional.ServicioID = id;

                        Boolean deleteServ = LogTipoDeHabitacion.Instancia.eliminarServicios(tipoHabitacion, servicioadicional);
                    }
                }

                return RedirectToAction("listarTiposH");
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction("insertarTipoHabitacion", new { mesjException = ex.Message });
            }
        }
        //Eliminar Servicios
    }
}