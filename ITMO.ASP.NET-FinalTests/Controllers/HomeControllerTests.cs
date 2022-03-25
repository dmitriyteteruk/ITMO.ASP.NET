using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO.ASP.NET_Final.Models;
using ITMO.ASP.NET_Final.Controllers;
using System.Data.Entity;
using System.IO;
using System.Text;
using System.Net.Http.Headers;
using ITMO.ASP.NET_Final.Controllers;

namespace ITMO.ASP.NET_Final.Controllers.Tests
{
	[TestClass()]
	public class HomeControllerTests
	{
		[TestMethod()]
		public void ActionExecutes_ReturnsView()
		{
			HomeController controller = new HomeController();
			var result = controller.Index();
			Assert.IsNotNull(result);
		}

	}
}