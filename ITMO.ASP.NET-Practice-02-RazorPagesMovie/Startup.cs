using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ITMO.ASP.NET_Practice_02_RazorPagesMovie.Data;
using System.Collections;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace ITMO.ASP.NET_Practice_02_RazorPagesMovie
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddRazorPages();

		    services.AddDbContext<ITMOASPNET_Practice_02_RazorPagesMovieContext>(options =>
		            options.UseSqlServer(Configuration.GetConnectionString("ITMOASPNET_Practice_02_RazorPagesMovieContext")));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
			}

			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapRazorPages();
			});

			var defaultCulture = new CultureInfo("en-US");
			var localizationOptions = new RequestLocalizationOptions
			{
				DefaultRequestCulture = new RequestCulture(defaultCulture),
				SupportedCultures = new List<CultureInfo> { defaultCulture },
				SupportedUICultures = new List<CultureInfo> { defaultCulture }
			};
			app.UseRequestLocalization(localizationOptions);
		}
	}
}
