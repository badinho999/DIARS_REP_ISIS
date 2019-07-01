using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaLogica;

namespace PlantillaDIARS.Controllers
{
    public class AccountController : Controller
    {
        //[HttpGet]
        //public ActionResult NuevaCuenta(int ClienteID)
        //{
        //    ViewBag.ClienteID = ClienteID;
        //    return View(ClienteID);
        //}
        //[HttpPost]
        //public ActionResult NuevaCuenta(FormCollection form)
        //{
        //    try
        //    {

        //        EntCliente cliente = new EntCliente
        //        {
        //            ClienteID = Convert.ToInt32(form["clienteID"])
        //        };

        //        EntAccount cuenta = new EntAccount
        //        {
        //            Cliente = cliente,
        //            Email = Convert.ToString(form["email"]),
        //            Fechacreacion = DateTime.Now.ToString("MM/dd/yyyy"),
        //            NombreUsuario = Convert.ToString(form["username"]),
        //            Telefono = Convert.ToString(form["telf"])                    
        //        };

        //        if (!ModelState.IsValid)
        //        {
        //            return View("NuevaCuenta", cliente);
        //        }

        //        bool nuevaCuenta = LogAccount.Instance.CrearCuenta(cuenta);

        //        if (nuevaCuenta)
        //        {
        //            return RedirectToAction("Index", "Home");
        //        }
        //        else
        //        {
        //            return View("NuevaCuenta", cuenta);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return RedirectToAction("NuevaCuenta", new { mesjException = ex.Message });
        //    }
        //}

        public JsonResult NewAccount(EntAccountViewData accountViewData)
        {
            //Crea cuenta primero
            bool cuentaCreada = LogCuenta.Instancia.CrearCuenta(accountViewData.Cuenta);
            //Encrypt Password
            string hashcode = LogHashing.Instance.Encrypt(accountViewData.Key);
            //string password = accountViewData.PasswordAccount.PasswordString;

            if (cuentaCreada)
            {

                EntPasswordAccount passwordAccount = new EntPasswordAccount
                {
                    PasswordString = LogHashing.Instance.Decrypt(accountViewData.Key)
                };

                //Verificamos si existe una contraseña de la lista hash

                bool existe = false;
                EntHashtable hashtable = LogHashtable.Instance.BuscarPasswordSingUp(hashcode);

                if(hashtable!=null)
                {
                    existe = true;
                }

                if (existe)
                {

                    EntAccountHashTable accountHashTable = new EntAccountHashTable
                    {
                        Cuenta = accountViewData.Cuenta,
                        Hashtable = hashtable
                    };

                    //Si se encontró enlaza la cuenta con la contraseña
                    if (LogAccountHashTable.Instance.EnlazarHashCuenta(accountHashTable))
                    {
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }

                    return Json(false, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    hashtable = new EntHashtable
                    {
                        HashCode = hashcode
                    };

                    //Si la contraseña es nueva, crea un nuevo hash
                    bool hashtableCreate = LogHashtable.Instance.NewHash(hashtable);

                    if(hashtableCreate)
                    {
                        passwordAccount.Hashtable = hashtable;

                        //Crea una nueva contraseña
                        bool newPassCreated = LogPasswordAccount.Instance.NewPassword(passwordAccount);

                        if(newPassCreated)
                        {
                            EntAccountHashTable accountHashTable = new EntAccountHashTable
                            {
                                Cuenta = accountViewData.Cuenta,
                                Hashtable = hashtable
                            };

                            //Enlaza la nueva contraseña
                            if(LogAccountHashTable.Instance.EnlazarHashCuenta(accountHashTable))
                            {
                                return Json(true, JsonRequestBehavior.AllowGet);
                            }

                            return Json(false, JsonRequestBehavior.AllowGet);
                        }
                        else
                        {

                            return Json(false, JsonRequestBehavior.AllowGet);
                        }

                    }
                    return Json(false, JsonRequestBehavior.AllowGet);

                }
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }

        //Verificar email
        
        public JsonResult VerifyEmail(string email)
        {
            return Json(LogCuenta.Instancia.VerifyEmail(email), JsonRequestBehavior.AllowGet);
        }
    }
}