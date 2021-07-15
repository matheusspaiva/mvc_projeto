using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using busnises;

namespace mvc_projeto.Controllers
{
    public class ProdutosController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Produtos = new Produtos().Retornavalores();
            return View();
        }

        public ActionResult Novo()
        {
            //cria objeto do tipo cliene e chama a função
            //salva em um viebag de nome cliente
            // ViewBag.cliente = new Cliente().nomes();
            return View();
        }
        [HttpPost]
        public void Adicionar()
        {
            Produtos produto = new Produtos();
            produto.id = Convert.ToInt32(Request["id"]);
            produto.nome = Request["nome"].ToString();
            produto.quantidade = Convert.ToInt32(Request["quantidade"]);
            produto.Salvar();
            Response.Redirect("/Produtos");
        }

       
        public ActionResult Editar(int Id)
        {
            var produto = new Produtos().Dados(Id);
            ViewBag.conteudo = produto;
            return View();
        }

        [HttpPost]
        public void Atualizar()
        {
            Produtos produto = new Produtos();
            produto.id = Convert.ToInt32(Request["id"]);
            produto.nome = Request["nome"].ToString();
            produto.quantidade = Convert.ToInt32(Request["quantidade"]);
            produto.Atualizar();
            Response.Redirect("/Produtos");
        }

        public void Excluir(int id)
        {
            Produtos produto = new Produtos();
            produto.Excluir(id);
            Response.Redirect("/Produtos");
        }
    }
}