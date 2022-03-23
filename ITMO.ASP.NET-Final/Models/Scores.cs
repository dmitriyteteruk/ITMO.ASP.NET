using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ITMO.ASP.NET_Final;


namespace ITMO.ASP.NET_Final.Models
{
	public class Scores
	{
		// уникальный ID оценки
		[Key]
		public virtual int ScoreId { get; set; }

		// Название дисциплины 
		[DisplayName("Дисциплина")]
		public virtual string Discipline { get; set; }

		// Имя
		[DisplayName("Имя")]
		public virtual string StudentName { get; set; }

		// дата отметки
		[DisplayName("Дата отметки")]
		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
		public virtual DateTime ScoreDate { get; set; }

		// балл
		[DisplayName("Балл")]
		public virtual int Score { get; set; }

	}
}