using Microsoft.AspNetCore.Mvc;
using LuxeStep.Models;

namespace LuxeStep.Controllers
{
    public class ContactoController : Controller
    {
        private readonly LuxeStepDbContext _context;

        public ContactoController(LuxeStepDbContext context)
        {
            _context = context;
        }

        // GET: Contacto
        public IActionResult Index()
        {
            return View();
        }

        // POST: Contacto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("NombreCompleto,Correo,Mensaje")] MensajeContacto mensajeContacto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mensajeContacto);
                await _context.SaveChangesAsync();
                
                TempData["SuccessMessage"] = "¡Mensaje enviado exitosamente! Nos pondremos en contacto contigo pronto.";
                ModelState.Clear();
                return View(new MensajeContacto());
            }
            return View(mensajeContacto);
        }
    }
}
