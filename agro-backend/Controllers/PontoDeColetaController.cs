using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace agro_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontoDeColetaController
    {
        [HttpGet]
        public void BuscarTodasFazendas()
        {
            return;
        }

        [HttpGet("{id}")]
        public void BuscarPorId(int id)
        {
            return;
        }

        [HttpPost()]
        public void Cadastrar()
        {
            return;
        }
    }
}

