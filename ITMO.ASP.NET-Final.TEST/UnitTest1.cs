using ITMO.ASP.NET_Final.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace ITMO.ASP.NET_Final.TEST
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			HomeController controller = new HomeController();
			var result = controller.Index();
			Assert.IsNotNull(result);
		}
	}
}
