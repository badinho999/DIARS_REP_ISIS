using CapaPresentacion.Models;
using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaLogica;
using Newtonsoft.Json.Linq;
using PayPal;
using Newtonsoft.Json;

namespace CapaPresentacion.Controllers
{
    public class PayPalController : Controller
    {

        #region methods
        public void verificarSesion()
        {
            if (Session["cuenta"] != null)
            {
                EntCuenta cuenta = (EntCuenta)Session["cuenta"];
                ViewBag.Cuenta = cuenta;
            }
        }

        #endregion methods

        public ActionResult CreatePayment(int id, double monto, double tax, double shipping)
        {
            var viewData = new PayPalViewData();
            var guid = Guid.NewGuid().ToString();

            var paymentInit = new Payment
            {
                intent = "authorize",
                payer = new Payer
                {
                    payment_method = "paypal"
                },
                transactions = new List<Transaction>
                {
                    new Transaction
                    {
                        amount = new Amount
                        {
                            currency = "USD",
                            total = (monto + tax + shipping).ToString(),
                            details = new Details
                            {
                                subtotal = monto.ToString(),
                                tax = tax.ToString(),
                                shipping = shipping.ToString()
                               
                            }
                            
                            
                        },
                        description = "Reservar una habitación"
                    }
                },
                redirect_urls = new RedirectUrls
                {
                    return_url = Utilities.ToAbsoluteUrl(HttpContext, string.Format("~/paypal/confirmed?id={0}", guid)),
                    cancel_url = Utilities.ToAbsoluteUrl(HttpContext, string.Format("~/paypal/canceled?id={0}", guid)),
                },
            };

            viewData.JsonRequest = JObject.Parse(paymentInit.ConvertToJson()).ToString(Formatting.Indented);

            try
            {
                var accessToken = new OAuthTokenCredential(ConfigManager.Instance.GetProperties()["clientId"], ConfigManager.Instance.GetProperties()["clientSecret"]).GetAccessToken();
                var apiContext = new APIContext(accessToken);
                var createdPayment = paymentInit.Create(apiContext);

                var approvalUrl = createdPayment.links.ToArray().FirstOrDefault(f => f.rel.Contains("approval_url"));

                if (approvalUrl != null)
                {
                    Session.Add(guid, createdPayment.id);

                    return Redirect(approvalUrl.href);
                }

                viewData.JsonResponse = JObject.Parse(createdPayment.ConvertToJson()).ToString(Formatting.Indented);

                return View("Error", viewData);
            }
            catch (PayPalException ex)
            {
                viewData.ErrorMessage = ex.Message;

                return View("Error", viewData);
            }
        }


        public ActionResult Confirmed(Guid id, string token, string payerId)
        {
            verificarSesion();

            var viewData = new ConfirmedViewData
            {
                Id = id,
                Token = token,
                PayerId = payerId
            };

            var accessToken = new OAuthTokenCredential(ConfigManager.Instance.GetProperties()["clientId"], ConfigManager.Instance.GetProperties()["clientSecret"]).GetAccessToken();
            var apiContext = new APIContext(accessToken);
            var payment = new Payment()
            {
                id = (string)Session[id.ToString()],
            };

            var executedPayment = payment.Execute(apiContext, new PaymentExecution { payer_id = payerId });

            viewData.AuthorizationId = executedPayment.transactions[0].related_resources[0].authorization.id;
            viewData.JsonRequest = JObject.Parse(payment.ConvertToJson()).ToString(Formatting.Indented);
            viewData.JsonResponse = JObject.Parse(executedPayment.ConvertToJson()).ToString(Formatting.Indented);

            //Sacando informacion de la reseva
            var reservaID = ((EntCuenta)Session["cuenta"]).ReservaID;
            var monto = ((EntCuenta)Session["cuenta"]).Monto;

            viewData.ReservaID = reservaID;
            viewData.Monto = monto;

            return View(viewData);
        }

        public ActionResult Canceled(Guid id, string token, string payerId)
        {
            return Content("Asshole.");
        }


        public ActionResult Capture(string authorizationId)
        {
            verificarSesion();
            var viewData = new ConfirmedViewData();

            try
            {
                var accessToken = new OAuthTokenCredential(ConfigManager.Instance.GetProperties()["clientId"], ConfigManager.Instance.GetProperties()["clientSecret"]).GetAccessToken();
                var apiContext = new APIContext(accessToken);
                var authorization = Authorization.Get(apiContext, authorizationId);

                if (authorization != null)
                {
                    var total = Convert.ToDouble(authorization.amount.total);

                    //Sacando informacion de la reseva
                    var reservaID = ((EntCuenta)Session["cuenta"]).ReservaID;
                    var monto = ((EntCuenta)Session["cuenta"]).Monto;

                    var capture = authorization.Capture(apiContext, new Capture
                    {
                        is_final_capture = true,
                        amount = new Amount
                        {
                            currency = "USD",
                            total = total.ToString("f2")                            
                            
                        },
                    });


                    viewData.JsonResponse = JObject.Parse(capture.ConvertToJson()).ToString(Formatting.Indented);

                    //Generando comprobante de pago
                    Random rdn = new Random();

                    EntReserva reserva = new EntReserva
                    {
                        ReservaID = reservaID
                        
                    };

                    EntComprobantepagoreserva fact = new EntComprobantepagoreserva
                    {
                        Monto = monto,
                        NumeroSerie = rdn.Next(10001, int.MaxValue),
                        Reserva = reserva
                    };

                    Boolean generarCPReserva = LogComprobanteReserva.Instancia.GenerarComprobanteReserva(fact);

                    //Limpiamos la información de la reserva
                    ((EntCuenta)Session["cuenta"]).ReservaID = 0;
                    ((EntCuenta)Session["cuenta"]).Monto = 0;

                    viewData.ReservaID = fact.Reserva.ReservaID;
                    viewData.Monto = fact.Monto;
                    viewData.Serie = fact.NumeroSerie;

                    return View("Success", viewData);
                }

                viewData.ErrorMessage = "Could not find previous authorization.";

                return View("Error", viewData);
            }
            catch (PayPalException ex)
            {
                viewData.ErrorMessage = ex.Message;

                return View("Error", viewData);
            }
        }

        public ActionResult Void(string authorizationId)
        {
            var viewData = new ConfirmedViewData();

            try
            {
                var accessToken = new OAuthTokenCredential(ConfigManager.Instance.GetProperties()["clientId"], ConfigManager.Instance.GetProperties()["clientSecret"]).GetAccessToken();
                var apiContext = new APIContext(accessToken);
                var authorization = Authorization.Get(apiContext, authorizationId);

                if (authorization != null)
                {
                    var voidedAuthorization = authorization.Void(apiContext);

                    viewData.JsonResponse = JObject.Parse(voidedAuthorization.ConvertToJson()).ToString(Formatting.Indented);

                    return RedirectToAction("Inicio","Menu");
                }

                viewData.ErrorMessage = "Could not find previous authorization.";

                return View("Error", viewData);
            }
            catch (PayPalException ex)
            {
                viewData.ErrorMessage = ex.Message;

                return View("Error", viewData);
            }
        }
    }
}