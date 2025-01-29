using EjercicioNasaConsumoAPIsRest.Models.DTO;
using EjercicioNasaConsumoAPIsRest.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace EjercicioNasaConsumoAPIsRest.Service
{
    public class PlanetaryService : PlanetaryRepository
    {
        private readonly string api_key = "xm0yI1lr2std9IUMadlgUMf000y3CRjBhdKweX8l";
        public async Task<PlanetaryResponse> obtenerRespuesta()
        {
            string api_nasa = $"https://api.nasa.gov/planetary/apod?api_key={api_key}";
            PlanetaryResponse data = null;
            try
            {
                using (var http = new HttpClient())
                {
                    http.BaseAddress = new Uri(api_nasa);
                    HttpResponseMessage message = await http.GetAsync(api_nasa);
                    string json = await message.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<PlanetaryResponse>(json);
                }
            }catch (Exception ex)
            {
                throw new Exception("No se pudo obtener la respuesta de la api: " + ex.Message);
            }
            return data;
        }
    }
}