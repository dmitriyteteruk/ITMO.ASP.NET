using System.Web;
using System.Web.Mvc;

namespace ITMO.ASP.NET_Practice_8
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
