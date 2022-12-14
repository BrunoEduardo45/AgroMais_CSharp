using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgroMais.Models
{
    public class Clientes
    {
        public int CLI_ID { get; set; }
        public string CLI_NOME { get; set; }
        public string CLI_CPF { get; set; }
        public string CLI_RG { get; set; }
        public bool CLI_SEXO { get; set; }
        public int CLI_IDADE { get; set; }
        public DateTime CLI_DATA_NASC { get; set; }
        public DateTime CLI_DATA_CADASTRO { get; set; }
        public string CLI_PROFISSAO { get; set; }
        public string CLI_TELEFONE { get; set; }
        public string CLI_CELULAR { get; set; }
        public string CLI_EMAIL { get; set; }
        public string CLI_LOGRADOURO { get; set; }
        public string CLI_MUNICIPIO { get; set; }
        public string CLI_BAIRRO { get; set; }
        public string CLI_NUMERO { get; set; }
        public string CLI_COMPLEMENTO { get; set; }
        public string CLI_CEP { get; set; }
        public string CLI_UF { get; set; }
        public string CLI_CNPJ { get; set; }

        public int ID { get; set; }
        public List<Clientes> listaclientes { get; set; }
    }
}