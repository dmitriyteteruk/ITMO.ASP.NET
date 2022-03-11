using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMO.ASP.NET_Practice_MVC_Lab._01_WebMVCR1.Models
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public override string ToString() 
			{ 
				string s = FirstName + " " + LastName; return s; 
			}
	}
}
