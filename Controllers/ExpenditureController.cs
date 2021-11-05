using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_mvc.Controllers
{
    public class ExpenditureController : Controller
    {
        List<Expenditure> depense { get; set; }

        double somme { get; set; }
        public ExpenditureController()
        {
            depense = new List<Expenditure> {
                new Expenditure("voiture", "02/11/2021", 25.21),
                new Expenditure("Maison", "31/10/2021", 52.21),
                new Expenditure("Nourriture", "01/11/2021", 105.21) };

            somme = depense.Sum(entre => entre.prix);
        }

        // GET: ExpenditureController
        public ActionResult Index()
        {
            return View(depense);
        }

        // GET: ExpenditureController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExpenditureController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExpenditureController/Create
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

        // GET: ExpenditureController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExpenditureController/Edit/5
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

        // GET: ExpenditureController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExpenditureController/Delete/5
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
