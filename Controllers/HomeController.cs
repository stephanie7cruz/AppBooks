using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppBooks.Data;
using AppBooks.Models;
using System.Diagnostics;

namespace AppBooks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Obtener la lista de libros y reseñas desde la base de datos
            var books = await _context.Books.ToListAsync();
            var reviews = await _context.Reviews.Include(r => r.Book).ToListAsync(); 

            // Pasar los datos a la vista mediante ViewData
            ViewData["Books"] = books;
            ViewData["Reviews"] = reviews;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
