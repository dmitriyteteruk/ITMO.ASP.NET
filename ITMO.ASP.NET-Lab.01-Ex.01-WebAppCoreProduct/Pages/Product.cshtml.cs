using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ITMO.ASP.NET_Lab._01_Ex._01_WebAppCoreProduct.Models;    // ���.1, ���.4

namespace ITMO.ASP.NET_Lab._01_Ex._01_WebAppCoreProduct.Pages
{
    public class ProductModel : PageModel
    {
        public string MessageRezult;
        public Product Product { get; set; }

        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = "�������� ������������ ������. ��������� ����";
                return;
            }
            var result = price * (decimal?)0.18;
            MessageRezult = $"��� ������ {name} � ����� {price} ������ ��������� {result}";
            Product.Price = price;
            Product.Name = name;
        }

        public void OnGet()
        {
            MessageRezult = "��� ������ ����� ���������� ������";
        }
    }
}
