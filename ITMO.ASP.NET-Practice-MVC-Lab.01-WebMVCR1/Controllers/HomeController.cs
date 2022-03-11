using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMO.ASP.NET_Practice_MVC_Lab._01_WebMVCR1.Models;

namespace ITMO.ASP.NET_Practice_MVC_Lab._01_WebMVCR1.Controllers
{
	public class HomeController : Controller
	{
		//public IActionResult Index()
		//{
		//	return View();
		//}

		public string Index(string hel)
		{
			string Greeting = ModelClass.ModelHello() + ", " + hel;
			return Greeting;
		}
	}
}
