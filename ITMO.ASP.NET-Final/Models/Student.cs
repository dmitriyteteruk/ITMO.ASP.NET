using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ITMO.ASP.NET_Final.Models
{
	public class Student
	{
		// id студента
		[Key]
		public virtual int StudentId { get; set; }

		// имя студента
		[DisplayName("Имя студента")]
		public virtual string StudentName { get; set; }

		[DisplayName("Сумма баллов по все дисциплинам")]
		// сумма баллов студента
		public virtual int StudentScoreSum { get; set; }
	}
}