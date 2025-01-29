using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioNasaConsumoAPIsRest.Models.DTO
{
    public class PlanetaryResponse
    {
        public string explanation { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string date { get; set; }
    }
}