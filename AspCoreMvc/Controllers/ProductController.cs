using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspCoreMvc.Controllers
{
    public class ProductController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //Get /Controller/milk
        [HttpGet]
        public IActionResult Milk()

        {
            return View();
        }

        [HttpPost]
        [ActionName("milk")]
        public IActionResult Milkw(string zozo)
        {
            return View(zozo);
        }

    }
}

