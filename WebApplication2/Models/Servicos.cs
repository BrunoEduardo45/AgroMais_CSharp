using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgroMais.Models
{
    public class Servicos
    {
        public int SRV_ID { get; set; }
        public int SRV_CLI_ID { get; set; }
        public int SRV_PROP_ID { get; set; }
        public int SRV_TIPO { get; set; }
        public int SRV_STATUS { get; set; }
        public string SRV_COMPLEMENTO { get; set; }
        public decimal SRV_VALOR { get; set; }
        public int SRV_TIPO_PAGAMENTO { get; set; }
        public int SRV_STATUS_PAGAMENTO { get; set; }
        public int SRV_VALOR_PAGO { get; set; }
    }
}