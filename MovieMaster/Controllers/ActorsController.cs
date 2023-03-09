using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieMaster.Data;

namespace MovieMaster.Controllers
{
    public class ActorsController : Controller
    {
        private readonly DataContext _context;
        public ActorsController(DataContext context)
        {
            _context = context;
        }
    
        public async Task<IActionResult> Index()
        {
            var actors = await _context.Actors.ToListAsync();
            return View();
        }
    }
}
