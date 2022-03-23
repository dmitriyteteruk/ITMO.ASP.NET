using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ITMO.ASP.NET_Final;

namespace ITMO.ASP.NET_Final.Models
{
	public class Discipline
	{
		// ID дисциплины
		[Key]
		public virtual int DisciplineId { get; set; }
		
		[DisplayName("Название дисциплины")]
		// Название дисциплины
		public virtual string DisciplineName { get; set; }

	}
}