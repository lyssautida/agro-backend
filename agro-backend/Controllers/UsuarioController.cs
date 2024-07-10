using agro_backend.Models;
using agro_backend.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace agro_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController
    {
        private readonly IUsuarioRepository _usuarioRepositorio;
        public UsuarioController(IUsuarioRepository usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosUsuarios()
        {
            List<UsuarioModel> usuarios = await _usuarioRepositorio.BuscarTodosUsuarios();
            return Ok(usuarios);
        }

        private ActionResult<List<UsuarioModel>> Ok(List<UsuarioModel> usuarios)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> BuscarPorId(int id)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarPorId(id);
            return Ok(usuario);
        }

        private ActionResult<UsuarioModel> Ok(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        [HttpPost()]
        public async Task<ActionResult<UsuarioModel>> Cadastrar([FromBody] UsuarioModel usuarioModel)
        {
            UsuarioModel usuario = await _usuarioRepositorio.Adicionar(usuarioModel);
            return Ok(usuario);
        }
    }
}
