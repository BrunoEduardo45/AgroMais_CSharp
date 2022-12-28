using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgroMais.Models;
using System.Data.SqlClient;
using SAPS.Util;
using System.Runtime.Remoting.Messaging;
using Microsoft.Ajax.Utilities;
using static AgroMais.Models.Servicos;

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
                parameters.Add(new SqlParameter("@CLI_NOME", !string.IsNullOrWhiteSpace(clientes.CLI_NOME) ? clientes.CLI_NOME : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_CPF", !string.IsNullOrWhiteSpace(clientes.CLI_CPF) ? clientes.CLI_CPF : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_RG", !string.IsNullOrWhiteSpace(clientes.CLI_RG) ? clientes.CLI_RG : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_SEXO", clientes.CLI_SEXO));
                parameters.Add(new SqlParameter("@CLI_DATA_NASC", clientes.CLI_DATA_NASC));
                parameters.Add(new SqlParameter("@CLI_PROFISSAO", !string.IsNullOrWhiteSpace(clientes.CLI_PROFISSAO) ? clientes.CLI_PROFISSAO : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_TELEFONE", !string.IsNullOrWhiteSpace(clientes.CLI_TELEFONE) ? clientes.CLI_TELEFONE : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_CELULAR", !string.IsNullOrWhiteSpace(clientes.CLI_CELULAR) ? clientes.CLI_CELULAR : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_EMAIL", !string.IsNullOrWhiteSpace(clientes.CLI_EMAIL) ? clientes.CLI_EMAIL : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_LOGRADOURO", !string.IsNullOrWhiteSpace(clientes.CLI_LOGRADOURO) ? clientes.CLI_LOGRADOURO : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_MUNICIPIO", !string.IsNullOrWhiteSpace(clientes.CLI_MUNICIPIO) ? clientes.CLI_MUNICIPIO : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_BAIRRO", !string.IsNullOrWhiteSpace(clientes.CLI_BAIRRO) ? clientes.CLI_BAIRRO : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_NUMERO", !string.IsNullOrWhiteSpace(clientes.CLI_NUMERO) ? clientes.CLI_NUMERO : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_COMPLEMENTO", !string.IsNullOrWhiteSpace(clientes.CLI_COMPLEMENTO) ? clientes.CLI_COMPLEMENTO : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_CEP", !string.IsNullOrWhiteSpace(clientes.CLI_CEP) ? clientes.CLI_CEP : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_CNPJ", !string.IsNullOrWhiteSpace(clientes.CLI_CNPJ) ? clientes.CLI_CNPJ : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_UF", !string.IsNullOrWhiteSpace(clientes.CLI_UF) ? clientes.CLI_UF : (Object)DBNull.Value));
                #endregion
                DatabaseHelper.ExecuteNonQueryStoredProcedure(procedure, parameters.ToArray());

                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }          
        public object atualizarCliente(Clientes clientes)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string procedure = @"sp_updateCliente";
            try
            {
                #region
                parameters.Add(new SqlParameter("@CLI_ID", clientes.CLI_ID));
                parameters.Add(new SqlParameter("@CLI_NOME", !string.IsNullOrWhiteSpace(clientes.CLI_NOME) ? clientes.CLI_NOME : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_CPF", !string.IsNullOrWhiteSpace(clientes.CLI_CPF) ? clientes.CLI_CPF : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_RG", !string.IsNullOrWhiteSpace(clientes.CLI_RG) ? clientes.CLI_RG : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_PROFISSAO", !string.IsNullOrWhiteSpace(clientes.CLI_PROFISSAO) ? clientes.CLI_PROFISSAO : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_TELEFONE", !string.IsNullOrWhiteSpace(clientes.CLI_TELEFONE) ? clientes.CLI_TELEFONE : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_CELULAR", !string.IsNullOrWhiteSpace(clientes.CLI_CELULAR) ? clientes.CLI_CELULAR : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_EMAIL", !string.IsNullOrWhiteSpace(clientes.CLI_EMAIL) ? clientes.CLI_EMAIL : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_LOGRADOURO", !string.IsNullOrWhiteSpace(clientes.CLI_LOGRADOURO) ? clientes.CLI_LOGRADOURO : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_MUNICIPIO", !string.IsNullOrWhiteSpace(clientes.CLI_MUNICIPIO) ? clientes.CLI_MUNICIPIO : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_BAIRRO", !string.IsNullOrWhiteSpace(clientes.CLI_BAIRRO) ? clientes.CLI_BAIRRO : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_NUMERO", !string.IsNullOrWhiteSpace(clientes.CLI_NUMERO) ? clientes.CLI_NUMERO : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_COMPLEMENTO", !string.IsNullOrWhiteSpace(clientes.CLI_COMPLEMENTO) ? clientes.CLI_COMPLEMENTO : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_CEP", !string.IsNullOrWhiteSpace(clientes.CLI_CEP) ? clientes.CLI_CEP : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_CNPJ", !string.IsNullOrWhiteSpace(clientes.CLI_CNPJ) ? clientes.CLI_CNPJ : (Object)DBNull.Value));
                parameters.Add(new SqlParameter("@CLI_UF", !string.IsNullOrWhiteSpace(clientes.CLI_UF) ? clientes.CLI_UF : (Object)DBNull.Value));
                #endregion
                DatabaseHelper.ExecuteNonQueryStoredProcedure(procedure, parameters.ToArray());

                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }  
        public object DeletarCliente(int id)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            string query = @"delete from clientes where cli_id = @cli_id";
            try
            {
                parameters.Add(new SqlParameter("@cli_id", id));
                DatabaseHelper.ExecuteNonQuery(query, parameters.ToArray());
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }        
        public List<Clientes> BuscarListaCliente()
        {
            Clientes clientes = null;
            List<Clientes> listaClientes = new List<Clientes>();
            string query = @"Select * from Clientes";
            SqlDataReader reader = null;
            List<SqlParameter> parameters = new List<SqlParameter>();
            try
            {

                reader = DatabaseHelper.ExecuteReader(query, parameters.ToArray());

                using (reader)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            clientes = new Clientes();
                            try { clientes.CLI_ID = reader.GetInt32(reader.GetOrdinal("CLI_ID")); } catch { }
                            try { clientes.CLI_NOME = reader.GetString(reader.GetOrdinal("CLI_NOME")); } catch { }
                            try { clientes.CLI_CPF = reader.GetString(reader.GetOrdinal("CLI_CPF")); } catch { }
                            try { clientes.CLI_RG = reader.GetString(reader.GetOrdinal("CLI_RG")); } catch { }
                            try { clientes.CLI_SEXO = reader.GetBoolean(reader.GetOrdinal("CLI_SEXO")); } catch { }
                            try { clientes.NASCIMENO = reader.GetString(reader.GetOrdinal("CLI_DATA_NASC")); } catch { }
                            try { clientes.CLI_DATA_CADASTRO = reader.GetDateTime(reader.GetOrdinal("CLI_DATA_CADASTRO")); } catch { }
                            try { clientes.CLI_PROFISSAO = reader.GetString(reader.GetOrdinal("CLI_PROFISSAO")); } catch { }
                            try { clientes.CLI_TELEFONE = reader.GetString(reader.GetOrdinal("CLI_TELEFONE")); } catch { }
                            try { clientes.CLI_CELULAR = reader.GetString(reader.GetOrdinal("CLI_CELULAR")); } catch { }
                            try { clientes.CLI_EMAIL = reader.GetString(reader.GetOrdinal("CLI_EMAIL")); } catch { }
                            try { clientes.CLI_LOGRADOURO = reader.GetString(reader.GetOrdinal("CLI_LOGRADOURO")); } catch { }
                            try { clientes.CLI_MUNICIPIO = reader.GetString(reader.GetOrdinal("CLI_MUNICIPIO")); } catch { }
                            try { clientes.CLI_BAIRRO = reader.GetString(reader.GetOrdinal("CLI_BAIRRO")); } catch { }
                            try { clientes.CLI_NUMERO = reader.GetString(reader.GetOrdinal("CLI_NUMERO")); } catch { }
                            try { clientes.CLI_COMPLEMENTO = reader.GetString(reader.GetOrdinal("CLI_COMPLEMENTO")); } catch { }
                            try { clientes.CLI_CEP = reader.GetString(reader.GetOrdinal("CLI_CEP")); } catch { }
                            try { clientes.CLI_CNPJ = reader.GetString(reader.GetOrdinal("CLI_CNPJ")); } catch { }
                            try { clientes.CLI_UF = reader.GetString(reader.GetOrdinal("CLI_UF")); } catch { }
                            listaClientes.Add(clientes);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listaClientes;
        }
        public List<TipoServico> BuscarTiposServicos()
        {
            TipoServico tipoServico = null;
            List<TipoServico> listaTipoServico = new List<TipoServico>();
            string query = @"Select * from Tipo_Servico";
            SqlDataReader reader = null;
            List<SqlParameter> parameters = new List<SqlParameter>();
            try
            {
                reader = DatabaseHelper.ExecuteReader(query, parameters.ToArray());
                using (reader)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tipoServico = new TipoServico();
                            try { tipoServico.TIP_SRV_ID = reader.GetInt32(reader.GetOrdinal("TIP_SRV_ID")); } catch { }
                            try { tipoServico.TIP_SRV_NOME = reader.GetString(reader.GetOrdinal("TIP_SRV_NOME")); } catch { }
                            listaTipoServico.Add(tipoServico);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listaTipoServico;
        }

        //-------------------------------------------------------//

        public object adicionarServico(Servicos servico)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string procedure = @"sp_addServico";
            try
            {
                #region
                parameters.Add(new SqlParameter("@SRV_CLI_ID", servico.SRV_CLI_ID));
                parameters.Add(new SqlParameter("@SRV_PROP_ID", servico.SRV_PROP_ID));
                parameters.Add(new SqlParameter("@SRV_TIPO", servico.SRV_TIPO));
                parameters.Add(new SqlParameter("@SRV_STATUS", servico.SRV_STATUS));
                parameters.Add(new SqlParameter("@SRV_COMPLEMENTO", servico.SRV_COMPLEMENTO));
                parameters.Add(new SqlParameter("@SRV_VALOR", servico.SRV_VALOR));
                parameters.Add(new SqlParameter("@SRV_TIPO_PAGAMENTO", servico.SRV_TIPO_PAGAMENTO));
                parameters.Add(new SqlParameter("@SRV_STATUS_PAGAMENTO", servico.SRV_STATUS_PAGAMENTO));
                parameters.Add(new SqlParameter("@SRV_VALOR_PAGO", servico.SRV_VALOR_PAGO));                
                #endregion
                DatabaseHelper.ExecuteNonQueryStoredProcedure(procedure, parameters.ToArray());

                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public object atualizarServico(Servicos servico)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string procedure = @"sp_updateServico";
            try
            {
                #region
                parameters.Add(new SqlParameter("@SRV_ID", servico.SRV_ID));
                parameters.Add(new SqlParameter("@SRV_CLI_ID", servico.SRV_CLI_ID));
                parameters.Add(new SqlParameter("@SRV_PROP_ID", servico.SRV_PROP_ID));
                parameters.Add(new SqlParameter("@SRV_TIPO", servico.SRV_TIPO));
                parameters.Add(new SqlParameter("@SRV_STATUS", servico.SRV_STATUS));
                parameters.Add(new SqlParameter("@SRV_COMPLEMENTO", servico.SRV_COMPLEMENTO));
                parameters.Add(new SqlParameter("@SRV_VALOR", servico.SRV_VALOR));
                parameters.Add(new SqlParameter("@SRV_TIPO_PAGAMENTO", servico.SRV_TIPO_PAGAMENTO));
                parameters.Add(new SqlParameter("@SRV_STATUS_PAGAMENTO", servico.SRV_STATUS_PAGAMENTO));
                parameters.Add(new SqlParameter("@SRV_VALOR_PAGO", servico.SRV_VALOR_PAGO));
                #endregion
                DatabaseHelper.ExecuteNonQueryStoredProcedure(procedure, parameters.ToArray());

                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public object deletarServico(int id)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            string query = @"delete from Servicos where srv_id = @srv_id";
            try
            {
                parameters.Add(new SqlParameter("@srv_id", id));
                DatabaseHelper.ExecuteNonQuery(query, parameters.ToArray());
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Servicos> BuscarListaServicos()
        {
            Servicos servicos = null;
            List<Servicos> listaServicos = new List<Servicos>();
            string query = @"Select * from Servicos
                            inner join clientes on SRV_CLI_ID = cli_id
                            inner join tipo_servico on tip_srv_id = srv_tipo";
            SqlDataReader reader = null;
            List<SqlParameter> parameters = new List<SqlParameter>();
            try
            {
                reader = DatabaseHelper.ExecuteReader(query, parameters.ToArray());

                using (reader)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            servicos = new Servicos();
                            try { servicos.SRV_CLI_ID = reader.GetInt32(reader.GetOrdinal("SRV_CLI_ID")); } catch { }
                            try { servicos.SRV_PROP_ID = reader.GetInt32(reader.GetOrdinal("SRV_PROP_ID")); } catch { }
                            try { servicos.SRV_TIPO = reader.GetInt32(reader.GetOrdinal("SRV_TIPO")); } catch { }
                            try { servicos.SRV_STATUS = reader.GetInt32(reader.GetOrdinal("SRV_STATUS")); } catch { }
                            try { servicos.SRV_COMPLEMENTO = reader.GetString(reader.GetOrdinal("SRV_COMPLEMENTO")); } catch { }
                            try { servicos.SRV_VALOR = reader.GetInt32(reader.GetOrdinal("SRV_VALOR")); } catch { }
                            try { servicos.SRV_TIPO_PAGAMENTO = reader.GetInt32(reader.GetOrdinal("SRV_TIPO_PAGAMENTO")); } catch { }
                            try { servicos.SRV_STATUS_PAGAMENTO = reader.GetInt32(reader.GetOrdinal("SRV_STATUS_PAGAMENTO")); } catch { }
                            try { servicos.SRV_VALOR_PAGO = reader.GetInt32(reader.GetOrdinal("SRV_VALOR_PAGO")); } catch { }
                            try { servicos.SRV_DATA_CADASTRO = reader.GetString(reader.GetOrdinal("SRV_DATA_CADASTRO")); } catch { }
                            try { servicos.CLI_NOME = reader.GetString(reader.GetOrdinal("CLI_NOME")); } catch { }
                            try { servicos.SRV_NOME = reader.GetString(reader.GetOrdinal("TIP_SRV_NOME")); } catch { }

                            listaServicos.Add(servicos);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listaServicos;
        }
        public List<Propriedades> BuscarPropriedadesCliente(int id)
        {
            Propriedades propriedade = null;
            List<Propriedades> listaPropriedades = new List<Propriedades>();
            string query = @"Select * from Propriedades where prop_cli_id = @cli_id";
            SqlDataReader reader = null;
            List<SqlParameter> parameters = new List<SqlParameter>();
            try
            {
                parameters.Add(new SqlParameter("@cli_id", id));
                reader = DatabaseHelper.ExecuteReader(query, parameters.ToArray());
                using (reader)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            propriedade = new Propriedades();
                            try { propriedade.PROP_ID = reader.GetInt32(reader.GetOrdinal("PROP_ID")); } catch { }
                            try { propriedade.PROP_NOME = reader.GetString(reader.GetOrdinal("PROP_NOME")); } catch { }
                            listaPropriedades.Add(propriedade);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listaPropriedades;
        }
    }
}