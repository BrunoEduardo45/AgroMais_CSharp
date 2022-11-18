using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgroMais.Models
{
    public class Propriedades
    {
        public int PROP_ID { get; set; }
        public int PROP_CLI_ID { get; set; }
        public string PROP_NOME { get; set; }
        public bool PROP_HERDEIROS { get; set; }
        public string PROP_MUNICIPIO { get; set; }
        public int PROP_INCRA { get; set; }
        public decimal PROP_AREA_HECTARE { get; set; }
        public decimal PROP_AREA_TAREFA { get; set; }
        public decimal PROP_PERIMETRO { get; set; }
    }
}