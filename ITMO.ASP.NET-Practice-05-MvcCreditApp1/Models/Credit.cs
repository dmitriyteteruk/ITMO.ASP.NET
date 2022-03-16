using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASP.NET_Practice_05_MvcCreditApp1.Models
{
	public class Credit
	{
		// id кредита
		public virtual int CreditId { get; set; }

		// название
		public virtual string Head { get; set; }

		// период кредитования
		public virtual int Period { get; set; }

		// максимальная сумма кредита 
		public virtual int Sum { get; set; }

		// процентная ставка
		public virtual int Procent { get; set; }
	}
}