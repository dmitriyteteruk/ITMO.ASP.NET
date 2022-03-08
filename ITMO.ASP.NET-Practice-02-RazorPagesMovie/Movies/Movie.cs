using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ITMO.ASP.NET_Practice_02_RazorPagesMovie.Movies
{
	public class Movie
	{	
		public int ID { get; set; }
		public string Title { get; set; }

		[DataType(DataType.Date)]	 // это указание на то, что показываем только ДАТУ без времени из типа данных Date
		public DateTime ReleaseDate { get; set; }
		public string Genre { get; set; }
		public decimal Price { get; set; }

	}
}
