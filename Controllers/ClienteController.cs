using Microsoft.AspNetCore.Mvc;
using LuxeStep.Models;
using Microsoft.EntityFrameworkCore;

namespace LuxeStep.Controllers
{
    public class ClienteController : Controller
    {
        private readonly LuxeStepDbContext _context;

        public ClienteController(LuxeStepDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var clientes = await _context.Clientes.ToListAsync();
            return View(clientes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nombre,Correo,Telefono,FechaNacimiento")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }
    }
}
