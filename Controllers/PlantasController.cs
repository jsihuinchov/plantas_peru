using Microsoft.AspNetCore.Mvc;
using plantas_peru.Models;

namespace plantas_peru.Controllers
{
    public class PlantasController : Controller
    {
        private readonly PlantasContext _context;

        public PlantasController(PlantasContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var lista = _context.Plantas.ToList(); // trae todas las plantas de la BD
            return View(lista); // manda la lista a la vista Index.cshtml
        }
    }
}
