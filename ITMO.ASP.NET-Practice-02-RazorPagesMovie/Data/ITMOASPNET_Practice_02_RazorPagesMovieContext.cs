using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ITMO.ASP.NET_Practice_02_RazorPagesMovie.Movies;

namespace ITMO.ASP.NET_Practice_02_RazorPagesMovie.Data
{
    public class ITMOASPNET_Practice_02_RazorPagesMovieContext : DbContext
    {
        public ITMOASPNET_Practice_02_RazorPagesMovieContext (DbContextOptions<ITMOASPNET_Practice_02_RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<ITMO.ASP.NET_Practice_02_RazorPagesMovie.Movies.Movie> Movie { get; set; }
    }
}
