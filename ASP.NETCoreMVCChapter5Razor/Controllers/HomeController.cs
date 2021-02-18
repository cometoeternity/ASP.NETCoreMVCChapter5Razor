using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCoreMVCChapter5Razor.Models;

namespace ASP.NETCoreMVCChapter5Razor.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            Product myProduct = new Product
            {
                ProductId = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275M
            };
            return View(myProduct);
        }
    }
}
