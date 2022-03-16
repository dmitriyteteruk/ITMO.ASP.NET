using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ITMO.ASP.NET_Practice_05_MvcCreditApp1.Models
{
	public class Credit
	{
		// id кредита
		public virtual int CreditId { get; set; }

		// название
		[DisplayName("Название кредит")]
		public virtual string Head { get; set; }

		// период кредитования
		[DisplayName("Период кредиторвания (мес)")]
		public virtual int Period { get; set; }

		// максимальная сумма кредита 
		[DisplayName("Сумма")]
		[DataType(DataType.Currency)]
		[DisplayFormat(DataFormatString = "{0:C0}")]
		public virtual int Sum { get; set; }

		// процентная ставка
		[DisplayName("Процентная ставка")]
		public virtual int Procent { get; set; }
	}
}