using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ITMO.ASP.NET_Practice_05_MvcCreditApp1.Models
{
	public class Bid
	{
		// id заявки
		public virtual int BidId { get; set; }

		// имя заявителя
		[DisplayName("Имя заявителя")]
		public virtual string Name { get; set; }

		// название кредита
		[DisplayName("Назначение кредита")]
		public virtual string CreditHead { get; set; }

		// дата подачи заявки
		[DisplayName("Дата подачи заявки")]
		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
		public virtual DateTime BidDate { get; set; }
	}
}