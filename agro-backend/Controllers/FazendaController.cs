using agro_backend.Models;
using agro_backend.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace agro_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FazendaController
    {
        private readonly IFazendaRepository _fazendaRepositorio;
        public FazendaController(IFazendaRepository fazendaRepositorio)
        {
            _fazendaRepositorio = fazendaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<FazendaModel>>> BuscarTodasFazendas()
        {
            List<FazendaModel> fazendas = await _fazendaRepositorio.BuscarTodasFazendas();
            return Ok(fazendas);
        }

        private ActionResult<List<FazendaModel>> Ok(List<FazendaModel> fazendas)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FazendaModel>> BuscarPorId(int id)
        {
            FazendaModel fazenda = await _fazendaRepositorio.BuscarPorId(id);
            return Ok(fazenda);
        }

        private ActionResult<FazendaModel> Ok(FazendaModel usuario)
        {
            throw new NotImplementedException();
        }

        [HttpPost()]
        public async Task<ActionResult<FazendaModel>> Cadastrar([FromBody] FazendaModel usuarioModel)
        {
            FazendaModel fazenda = await _fazendaRepositorio.Adicionar(usuarioModel);
            return Ok(fazenda);
        }
    }
}
