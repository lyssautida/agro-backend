using agro_backend.Models;
using agro_backend.Repositories.Interfaces;
using agro_models.Models;
using Microsoft.AspNetCore.Mvc;

namespace agro_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalhaoController
    {
        private readonly ITalhaoRepository _talhaoRepository;
        public TalhaoController(ITalhaoRepository talhaoRepository)
        {
            _talhaoRepository = talhaoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<TalhaoModel>>> BuscarTodosTalhoes()
        {
            List<TalhaoModel> talhoes = await _talhaoRepository.BuscarTodosTalhoes();
            return Ok(talhoes);
        }

        private ActionResult<List<TalhaoModel>> Ok(List<TalhaoModel> talhoes)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TalhaoModel>> BuscarPorId(int id)
        {
            TalhaoModel talhao = await _talhaoRepository.BuscarPorId(id);
            return Ok(talhao);
        }

        private ActionResult<TalhaoModel> Ok(TalhaoModel talhao)
        {
            throw new NotImplementedException();
        }

        [HttpPost()]
        public async Task<ActionResult<TalhaoModel>> Cadastrar([FromBody] TalhaoModel talhaoModel)
        {
            TalhaoModel talhao = await _talhaoRepository.Adicionar(talhaoModel);
            return Ok(talhao);
        }
    }
}
