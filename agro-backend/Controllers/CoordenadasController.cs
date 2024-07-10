using agro_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace agro_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordenadasController
    {
        [HttpGet]
        public IActionResult BuscarCoordenadas()
        {

            var coordenadasRetorno = new
            {

                coordenadas = "-15.6014, Longitude: -56.0979",
                cidade = "Cuiabá",
                uf = "MT",
            };
            return new JsonResult(coordenadasRetorno);
        }
    }
}
