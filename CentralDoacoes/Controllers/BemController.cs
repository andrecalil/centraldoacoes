using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CentralDoacoes.Models.Bem;

namespace CentralDoacoes.Controllers
{
    public class BemController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
            var vm = new BemDetails();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BemDetails bem)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}