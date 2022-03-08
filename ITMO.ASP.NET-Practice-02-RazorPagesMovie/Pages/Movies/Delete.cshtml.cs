using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ITMO.ASP.NET_Practice_02_RazorPagesMovie.Data;
using ITMO.ASP.NET_Practice_02_RazorPagesMovie.Movies;

namespace ITMO.ASP.NET_Practice_02_RazorPagesMovie.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly ITMO.ASP.NET_Practice_02_RazorPagesMovie.Data.ITMOASPNET_Practice_02_RazorPagesMovieContext _context;

        public DeleteModel(ITMO.ASP.NET_Practice_02_RazorPagesMovie.Data.ITMOASPNET_Practice_02_RazorPagesMovieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FindAsync(id);

            if (Movie != null)
            {
                _context.Movie.Remove(Movie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
