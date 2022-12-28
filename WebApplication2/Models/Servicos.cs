using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgroMais.Models
{
    public class Servicos : Clientes
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
        public string SRV_DATA_CADASTRO { get; set; }
        public string SRV_NOME { get; set; }


        public List<Servicos> listaServicos { get; set; }
        public List<Clientes> listaClientes { get; set; }
        public List<Propriedades> listaPropriedade { get; set; }
        public List<TipoServico> listaTipoServicos { get; set; }

        public class TipoServico 
        {
            public int TIP_SRV_ID { get; set; }
            public string TIP_SRV_NOME { get; set; }

        }
    }
}