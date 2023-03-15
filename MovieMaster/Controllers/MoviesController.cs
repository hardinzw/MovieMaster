using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieMaster.Data;

namespace MovieMaster.Controllers
{
    public class MoviesController : Controller
    {
        private readonly DataContext _context;
        public MoviesController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies.Include(t => t.Theater).OrderBy(m => m.Title).ToListAsync();
            return View(movies);
        }
    }
}
