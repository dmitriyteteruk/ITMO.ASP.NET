using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO.ASP.NET_Practice_MVC_05_08.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace ITMO.ASP.NET_Practice_MVC_05_08.Controllers
{
	public class HomeController : Controller
	{
		private CreditContext db = new CreditContext();
		public ActionResult Index()
		{
			GiveCredits();
			return View();
		}

		private void GiveCredits()
		{
			var allCredits = db.Credits.ToList<Credit>();
			ViewBag.Credits = allCredits;
		}

		[Authorize]
		[HttpGet]
		public ActionResult CreateBid()
		{
			GiveCredits();
			var allBids = db.Bids.ToList<Bid>();
			ViewBag.Bids = allBids;
			return View();
		}

		[HttpPost]
		public string CreateBid(Bid newBid)
		{
			newBid.BidDate = DateTime.Now;
			// добавляем новую завявку в БД с датой сейчас
			db.Bids.Add(newBid);
			// сохраняем данные в БД
			db.SaveChanges();
			return "Спасибо, <b>" + newBid.Name + "</b>, за выбор нашего банка. " +
				"</br>Ваша заявка будет рассмотрена в течении 10 дней.";
		}

		public ActionResult BidSearch(string name)
		{
			var allBids = db.Bids.Where(a => a.CreditHead.Contains(name)).ToList();
			if (allBids.Count == 0)
			{
				return Content("Указанный кредит " + name + " не найден.");
				// http not found
			}
			return PartialView(allBids);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Страница описания приложения.";
			IList<string> roles = new List<string>{ "Роль не определена"};
			ApplicationUserManager userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
			ApplicationUser user = userManager.FindByEmail(User.Identity.Name);
			if (user != null)
				roles = userManager.GetRoles(user.Id);
			ViewBag.rol = roles;

			return View();

		}


	}
}