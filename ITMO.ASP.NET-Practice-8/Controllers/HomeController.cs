using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO.ASP.NET_Practice_05_MvcCreditApp1.Models;

namespace ITMO.ASP.NET_Practice_05_MvcCreditApp1.Controllers
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


	}
}