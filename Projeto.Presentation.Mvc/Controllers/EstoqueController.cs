using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Mvc.Controllers
{
    public class EstoqueController : Controller
    {
        // GET: EstoqueController
        public ActionResult Cadastro()
        {
            return View();
        }

        // GET: EstoqueController/Details/5
        public ActionResult Consulta()
        {
            return View();
        }

        // GET: EstoqueController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstoqueController/Create
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

        // GET: EstoqueController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstoqueController/Edit/5
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

        // GET: EstoqueController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstoqueController/Delete/5
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
