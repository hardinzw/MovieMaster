using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieMaster.Data;

namespace MovieMaster.Controllers
{
    public class TheatersController : Controller
    {
        private readonly DataContext _context;
        public TheatersController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var theaters = await _context.Theaters.ToListAsync();
            return View(theaters);
        }
    }
}
