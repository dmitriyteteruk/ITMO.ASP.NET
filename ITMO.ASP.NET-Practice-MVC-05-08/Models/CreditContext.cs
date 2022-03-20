﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.ASP.NET_Practice_MVC_05_08.Models
{
	public class CreditContext : DbContext
	{
		public DbSet<Credit> Credits { get; set; }
		public DbSet<Bid> Bids { get; set; }
	}
}