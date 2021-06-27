using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Mvc.Controllers
{
    public class VendidoController : Controller
    {
        // GET: VendidoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VendidoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VendidoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VendidoController/Create
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

        // GET: VendidoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VendidoController/Edit/5
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

        // GET: VendidoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VendidoController/Delete/5
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
