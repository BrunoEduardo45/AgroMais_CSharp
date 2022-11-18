using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgroMais.Models
{
    public class Herdeiros_Propriedade
    {
        public int HER_PROP_ID { get; set; }
        public int HER_PROP_CLI_ID { get; set; }
        public int HER_PROP_PROP_ID { get; set; }
        public string HER_PROP_NOME { get; set; }
        public decimal HER_PROP_AREA { get; set; }
    }
}