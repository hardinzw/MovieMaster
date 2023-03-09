using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieMaster.Data;

namespace MovieMaster.Controllers
{
    public class ProducersController : Controller
    {
        private readonly DataContext _context;
        public ProducersController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var producers = await _context.Producers.ToListAsync();
            return View();
        }
    }
}
