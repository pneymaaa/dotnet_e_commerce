using dotnet_e_commerce.Data;
using dotnet_e_commerce.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace dotnet_e_commerce.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsServices _service;

        public ActorsController(IActorsServices service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}