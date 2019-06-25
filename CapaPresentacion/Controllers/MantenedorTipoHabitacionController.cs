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
        public void verificarSesion()
        {
            if (Session["cuenta"] != null)
            {
                EntCuenta cuenta = (EntCuenta)Session["cuenta"];
                ViewBag.Cuenta = cuenta;
            }
        }

        // GET: TipoHabitacion
        public ActionResult listarTiposH()
        {
            verificarSesion();
            List<EntTipoDeHabitacion> lista = new List<EntTipoDeHabitacion>();
            foreach (EntTipoDeHabitacion thabitacion in LogTipoDeHabitacion.Instancia.ListarTiposH())
            {
                int ID = thabitacion.TipodehabitacionID;
                List<EntServicioadicional> servs = LogServiciosAdicionales.Instancia.ObtenerServicios(ID);
                thabitacion.ServiciosAdicionales = servs;
                lista.Add(thabitacion);
            }
            ViewBag.lista = lista;
            return View(lista);
        }

        [HttpGet]
        public ActionResult insertarTipoHabitacion()
        {
            verificarSesion();
            return View();
        }

        [HttpPost]
        public ActionResult insertarTipoHabitacion(EntTipoDeHabitacion tipoHabitacion)
        {
            try
            {
                Boolean inserta = LogTipoDeHabitacion.Instancia.IngresarTipoH(tipoHabitacion);
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
            verificarSesion();
            EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion();
            tipoDeHabitacion = LogTipoDeHabitacion.Instancia.BuscarTipoH(TipodehabitacionID);

            return View(tipoDeHabitacion);
        }

        [HttpPost]
        public ActionResult editarTipoH(EntTipoDeHabitacion tipoHabitacion)
        {
            try
            {
                Boolean edit = LogTipoDeHabitacion.Instancia.EditarTipoH(tipoHabitacion);
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
            verificarSesion();
            EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion();
            tipoDeHabitacion = LogTipoDeHabitacion.Instancia.BuscarTipoH(TipodehabitacionID);

            return View(tipoDeHabitacion);
        }

        [HttpPost]
        public ActionResult eliminarTipoH(EntTipoDeHabitacion tipoHabitacion)
        {
            try
            {
                Boolean delete = LogTipoDeHabitacion.Instancia.EliminarTipoH(tipoHabitacion);
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
            verificarSesion();
            List<EntServicioadicional> listarServicios = LogServiciosAdicionales.Instancia.ListarServicios();

            var listaServicios = new MultiSelectList(listarServicios, "ServicioID", "NombreDeServicio");
            ViewBag.listaServicios = listaServicios;

            EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion();
            tipoDeHabitacion = LogTipoDeHabitacion.Instancia.BuscarTipoH(TipodehabitacionID);

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
            verificarSesion();
            List<EntServicioadicional> listarServicios = LogServiciosAdicionales.Instancia.ObtenerServicios(TipodehabitacionID);

            var listaServicios = new MultiSelectList(listarServicios, "ServicioID", "NombreDeServicio");
            ViewBag.listaServicios = listaServicios;

            EntTipoDeHabitacion tipoDeHabitacion = new EntTipoDeHabitacion();
            tipoDeHabitacion = LogTipoDeHabitacion.Instancia.BuscarTipoH(TipodehabitacionID);

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

                        Boolean deleteServ = LogTipoDeHabitacion.Instancia.EliminarServicios(tipoHabitacion, servicioadicional);
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