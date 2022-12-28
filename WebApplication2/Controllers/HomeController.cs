using System;
using System.Web.Mvc;
using AgroMais.Models;
using AgroMais.DAO;
using System.Collections.Generic;
using static AgroMais.Models.Servicos;

namespace AgroMais.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeDAO dao = new HomeDAO();
            var servicos = new Servicos();
            var listaServicos = new List<Servicos>();
            var listaClientes = new List<Clientes>();
            var listaTipoServicos = new List<TipoServico>();
            try
            {
                listaServicos = dao.BuscarListaServicos();
                listaClientes = dao.BuscarListaCliente();
                listaTipoServicos = dao.BuscarTiposServicos();

            }
            catch (Exception) { }

            servicos.listaServicos = listaServicos;
            servicos.listaClientes = listaClientes;
            servicos.listaTipoServicos = listaTipoServicos;
            return View(servicos);
        }        
        public ActionResult Clientes()
        {
            HomeDAO dao = new HomeDAO();
            var cliente = new Clientes();
            var lista = new List<Clientes>(); 
            try 
            {
                lista = dao.BuscarListaCliente();
            }
            catch (Exception) { }

            cliente.listaclientes = lista;
            return View(cliente);
        }
        public ActionResult Configuracao()
        {
            return View();
        }

        //--------------------------------------------------------//
       
        [HttpPost]
        public JsonResult adicionarCliente(Clientes cliente)
        {
            HomeDAO dao = new HomeDAO();
            try
            {
                dao.adicionarCliente(cliente);
            }
            catch (Exception ex) { return Json(new { erro = true, mensagem = ex.Message, status = "ERRO" }); }
            return Json(new { erro = false, mensagem = "Cliente adicionado com sucesso!", status = "SUCESSO" });
        }       
        
        [HttpPost]
        public JsonResult atualizarCliente(Clientes cliente)
        {
            HomeDAO dao = new HomeDAO();
            try
            {
                dao.atualizarCliente(cliente);
            }
            catch (Exception ex) { return Json(new { erro = true, mensagem = ex.Message, status = "ERRO" }); }
            return Json(new { erro = false, mensagem = "Cliente atualizado com sucesso!", status = "SUCESSO" });
        }     

        [HttpPost]
        public JsonResult deletarCliente(Clientes cliente)
        {
            HomeDAO dao = new HomeDAO();
            try
            {
                dao.DeletarCliente(cliente.CLI_ID);
            }
            catch (Exception ex) { return Json(new { erro = true, mensagem = ex.Message, status = "ERRO" }); }
            return Json(new { erro = false, mensagem = "Cliente removido com sucesso!", status = "SUCESSO" });
        }
        
        //--------------------------------------------------------//

        [HttpPost]
        public JsonResult adicionarServico(Servicos servico)
        {
            HomeDAO dao = new HomeDAO();
            try
            {
                dao.adicionarServico(servico);
            }
            catch (Exception ex) { return Json(new { erro = true, mensagem = ex.Message, status = "ERRO" }); }
            return Json(new { erro = false, mensagem = "Serviço adicionado com sucesso!", status = "SUCESSO" });
        }

        [HttpPost]
        public JsonResult atualizarServico(Servicos servico)
        {
            HomeDAO dao = new HomeDAO();
            try
            {
                dao.atualizarServico(servico);
            }
            catch (Exception ex) { return Json(new { erro = true, mensagem = ex.Message, status = "ERRO" }); }
            return Json(new { erro = false, mensagem = "Serviço atualizado com sucesso!", status = "SUCESSO" });
        }

        [HttpPost]
        public JsonResult deletarServico(Servicos servico)
        {
            HomeDAO dao = new HomeDAO();
            try
            {
                dao.deletarServico(servico.SRV_ID);
            }
            catch (Exception ex) { return Json(new { erro = true, mensagem = ex.Message, status = "ERRO" }); }
            return Json(new { erro = false, mensagem = "Serviço removido com sucesso!", status = "SUCESSO" });
        }

        [HttpGet]
        public ActionResult BuscarListaPropriedades(int id)
        {
            List<Propriedades> propriedades = new List<Propriedades>();
            var servicos = new Servicos();
            HomeDAO dao = new HomeDAO();

            try
            {
                propriedades = dao.BuscarPropriedadesCliente(id);
            }
            catch { }

            servicos.listaPropriedade = propriedades;

            return Json(new { retorno = propriedades }, JsonRequestBehavior.AllowGet);
        }

    }
}