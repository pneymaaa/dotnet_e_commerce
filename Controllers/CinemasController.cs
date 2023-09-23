using dotnet_e_commerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_e_commerce.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index() 
        {
            var data = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}