using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMO.ASP.NET_Practice_MVC_Lab._01_WebMVCR1.Models
{
	public class ModelClass
	{
		public static string ModelHello()
		{
			int hour = DateTime.Now.Hour;
			string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
			return Greeting;
		}
	}
}
