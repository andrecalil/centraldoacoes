using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CentralDoacoes.Models.Doador;

namespace CentralDoacoes.Controllers
{
    public class DoadorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
            var vm = new DoadorDetails();
            return View(vm);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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