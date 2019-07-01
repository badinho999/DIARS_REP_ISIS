using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CapaEntidades
{
    public class EntHuesped : EntUserAccount
    {
        public string Dni { get; set; }     
    }
}
