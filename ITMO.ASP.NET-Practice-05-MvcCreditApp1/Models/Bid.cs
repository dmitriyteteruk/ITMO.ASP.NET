using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASP.NET_Practice_05_MvcCreditApp1.Models
{
	public class Bid
	{
		// id заявки
		public virtual int BidId { get; set; }

		// имя заявителя
		public virtual string Name { get; set; }

		// название кредита
		public virtual string CreditHead { get; set; }

		// дата подачи заявки
		public virtual DateTime BidDate { get; set; }
	}
}