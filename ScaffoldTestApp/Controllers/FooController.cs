using Microsoft.AspNetCore.Mvc;
using ScaffoldTestApp.Models;
using System.Collections.Generic;

namespace ScaffoldTestApp.Controllers
{
    public class FooController : Controller
    {
        private static List<Foo> items = new List<Foo>();

        public ActionResult Index()
        {
            return View(items);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Foo foo)
        {
            try
            {
                items.Add(foo);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}