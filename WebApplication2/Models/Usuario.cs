using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgroMais.Models
{
    public class Usuario
    {
        public int USU_ID { get; set; }
        public string USU_NOME { get; set; }
        public string USU_CARGO { get; set; }
        public string USU_EMAIL { get; set; }
        public string USU_SENHA { get; set; }
    }
}