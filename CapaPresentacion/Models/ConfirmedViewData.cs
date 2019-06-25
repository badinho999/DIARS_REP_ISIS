using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaPresentacion.Models
{
    public class ConfirmedViewData : PayPalViewData
    {
        public Guid Id { get; set; }

        public string Token { get; set; }

        public string PayerId { get; set; }

        public string AuthorizationId { get; set; }

        public int ReservaID { get; set; }

        public int Serie { get; set; }

        public double Monto { get; set; }

      

    }

}