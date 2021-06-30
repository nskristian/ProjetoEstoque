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

        // GET: ProdutoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdutoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProdutoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
