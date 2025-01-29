using EjercicioNasaConsumoAPIsRest.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNasaConsumoAPIsRest.Repository
{
    internal interface PlanetaryRepository
    {
        Task<PlanetaryResponse> obtenerRespuesta();
    }
}
