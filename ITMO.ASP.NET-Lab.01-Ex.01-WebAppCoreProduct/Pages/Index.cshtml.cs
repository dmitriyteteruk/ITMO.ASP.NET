using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ITMO.ASP.NET_Lab._01_Ex._01_WebAppCoreProduct.Models;    // Ћаб.1, упр.2
                                                               
namespace ITMO.ASP.NET_Lab._01_Ex._01_WebAppCoreProduct.Pages
{
    public class IndexModel : PageModel
    {
        
        public bool IsCorrect { get; set; } = true;
        public Product Product { get; set; }
        public void OnGet(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                IsCorrect = false;
                return;
            }
            Product.Price = price;
            Product.Name = name;
        }
    }
}
