using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgroMais.Models;
using System.Data.SqlClient;
using SAPS.Util;

namespace AgroMais.DAO
{
    public class HomeDAO
    {
        public object adicionarCliente(Clientes clientes)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string procedure = @"sp_addCliente";
            try
            {
                #region
                parameters.Add(new SqlParameter("@CLI_NOME", clientes.CLI_NOME));
                parameters.Add(new SqlParameter("@CLI_CPF", clientes.CLI_CPF));
                parameters.Add(new SqlParameter("@CLI_RG", clientes.CLI_RG));
                parameters.Add(new SqlParameter("@CLI_SEXO", clientes.CLI_SEXO));
                parameters.Add(new SqlParameter("@CLI_DATA_NASC", clientes.CLI_DATA_NASC));
                parameters.Add(new SqlParameter("@CLI_PROFISSAO", clientes.CLI_PROFISSAO));
                parameters.Add(new SqlParameter("@CLI_TELEFONE", clientes.CLI_TELEFONE));
                parameters.Add(new SqlParameter("@CLI_CELULAR", clientes.CLI_CELULAR));
                parameters.Add(new SqlParameter("@CLI_EMAIL", clientes.CLI_EMAIL));
                parameters.Add(new SqlParameter("@CLI_LOGRADOURO", clientes.CLI_LOGRADOURO));
                parameters.Add(new SqlParameter("@CLI_MUNICIPIO", clientes.CLI_MUNICIPIO));
                parameters.Add(new SqlParameter("@CLI_BAIRRO", clientes.CLI_BAIRRO));
                parameters.Add(new SqlParameter("@CLI_NUMERO", clientes.CLI_NUMERO));
                parameters.Add(new SqlParameter("@CLI_COMPLEMENTO", clientes.CLI_COMPLEMENTO));
                parameters.Add(new SqlParameter("@CLI_CEP", clientes.CLI_CEP));
                parameters.Add(new SqlParameter("@CLI_CNPJ", clientes.CLI_CNPJ));
                #endregion
                DatabaseHelper.ExecuteNonQueryStoredProcedure(procedure, parameters.ToArray());

                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}