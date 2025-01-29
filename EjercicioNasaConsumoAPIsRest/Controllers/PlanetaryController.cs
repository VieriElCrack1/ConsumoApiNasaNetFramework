using EjercicioNasaConsumoAPIsRest.Models.DTO;
using EjercicioNasaConsumoAPIsRest.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EjercicioNasaConsumoAPIsRest.Controllers
{
    public class PlanetaryController : Controller
    {
        private readonly PlanetaryService service = new PlanetaryService();

        public async Task<ActionResult> Index()
        {
            PlanetaryResponse response = await service.obtenerRespuesta();
            return View(response);
        }
    }
}