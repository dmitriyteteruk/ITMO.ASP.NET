﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMO.ASP.NET_Practice_MVC_Lab._01_WebMVCR1.Models;


namespace ITMO.ASP.NET_Practice_MVC_Lab._01_WebMVCR1.Controllers
{
	public class HomeController : Controller
	{
		public ViewResult Index()
		{
			int hour = DateTime.Now.Hour; 
			ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день"; 
			ViewData["Mes"] = "хорошего настроения";
			return View();
		}

		[HttpGet]
		public ViewResult InputData() 
		{
			return View(); 
		}

		[HttpPost]
		public ViewResult InputData(Person p)
		{
			db.AddResponse(p);
			return View("Hello", p);
		}

		private static PersonRepository db = new PersonRepository();

		public ViewResult OutputData() 
		{ 
			ViewBag.Pers = db.GetAllResponses; 
			ViewBag.Count = db.NumberOfPerson; 
			return View("ListPerson"); 
		}

		//public string Index(string hel)
		//{
		//	string Greeting = ModelClass.ModelHello() + ", " + hel;
		//	return Greeting;
		//}
	}
}
