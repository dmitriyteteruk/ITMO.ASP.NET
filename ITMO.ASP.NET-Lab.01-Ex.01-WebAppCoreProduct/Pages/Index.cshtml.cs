using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ITMO.ASP.NET_Lab._01_Ex._01_WebAppCoreProduct.Pages
{
    public class IndexModel : PageModel
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public bool IsCorrect { get; set; } = true;
        public void OnGet(string name, decimal? price)
        {
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                IsCorrect = false;
                return;
            }
            Price = price;
            Name = name;
        }
    }
}
