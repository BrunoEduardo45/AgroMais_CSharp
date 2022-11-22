using System;
using System.Web.Mvc;
using AgroMais.Models;
using AgroMais.DAO;

namespace AgroMais.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }        
        public ActionResult addServico()
        {
            return View();
        }
        public ActionResult Clientes()
        {
            return View();
        }
        public ActionResult addCliente()
        {
            return View();
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
    }
}