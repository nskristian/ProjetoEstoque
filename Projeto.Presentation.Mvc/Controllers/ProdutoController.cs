using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Presentation.Mvc.Models;
using Projeto.Repository.Entities;
using Projeto.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Mvc.Controllers
{
    public class ProdutoController : Controller
    {
        
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastro(ProdutoCadastroModel model, [FromServices] ProdutoRepository produtoRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (produtoRepository.GetByName(model.Nome) != null)
                    {
                        throw new Exception("Produto já existe.");
                    }
                    var produto = new Produto();
                    produto.Nome = model.Nome;
                    produto.Preco = model.Preco;

                    produtoRepository.Create(produto);

                    TempData["MensagemSucesso"] = "Produto cadastrado com sucesso.";
                    ModelState.Clear(); 

                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = "Erro: " + e.Message;
                }
            }
            return View();
        }

        
        public ActionResult Consulta([FromServices] ProdutoRepository produtoRepository)
        {
            var produtos = new List<Produto>();
            try
            {
                produtos = produtoRepository.GetAll();
            }
            catch(Exception e)
            {
                TempData["MensagemErro"] = "Erro: " + e.Message;
            }
            return View(produtos);
        }

        
        public ActionResult Exclusao(int id, [FromServices] ProdutoRepository produtoRepository)
        {
            try
            {
                var produto = produtoRepository.GetById(id);
                
                if(produto != null)
                {
                    produtoRepository.Delete(produto);

                    TempData["MensagemSucesso"] = "Produto excluído com sucesso.";
                }
                else
                {
                    throw new Exception("Produto não encontrado.");
                }
            }
            catch(Exception e)
            {
                TempData["MensagemErro"] = "Erro: " + e.Message;
            }
            return RedirectToAction("Consulta");
        }

        
        public ActionResult Edicao(int id, [FromServices] ProdutoRepository produtoRepository)
        {
            var model = new ProdutoEdicaoModel();

            try
            {
                var produto = produtoRepository.GetById(id);

                model.IdProduto = produto.IdProduto;
                model.Nome = produto.Nome;
                model.Preco = produto.Preco.ToString("F2");
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = "Erro: " + e.Message;
            }
            return View(model);
        }


        // POST: ProdutoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edicao(ProdutoEdicaoModel model, [FromServices] ProdutoRepository produtoRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var produto = new Produto();

                    produto.IdProduto = model.IdProduto;
                    produto.Nome = model.Nome;
                    produto.Preco = double.Parse(model.Preco);

                    produtoRepository.Update(produto);

                    TempData["MensagemSucesso"] = "Produto atualizado com sucesso.";
                }
                catch(Exception e)
                {
                    TempData["MensagemErro"] = "Erro: " + e.Message;
                }
            }
            return RedirectToAction("Consulta");
        }

    }
}
