using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.ASP.NET_Final.Models
{
	public class AllDbContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Discipline> Disciplines { get; set; }
		public DbSet<Scores> Scores { get; set; }
	}
}