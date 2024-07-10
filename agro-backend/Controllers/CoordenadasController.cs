using agro_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace agro_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordenadasController
    {
        [HttpGet]
        public String BuscarCoordenadas()
        {

            var coordenadasRetorno = new
            {

                coordenadas = "Latitude: -15.6014, Longitude: -56.0979",
                cidade = "Cidade: Cuiabá",
                uf = "UF: MT",
            };
            return Ok(coordenadasRetorno);
        }

        private string Ok(object coordenadasRetorno)
        {
            throw new NotImplementedException();
        }
    }
}
