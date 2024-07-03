using agro_backend.Data;
using agro_backend.Models;
using agro_backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace agro_backend.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AgroDBContext _dBContext;

        public UsuarioRepository(AgroDBContext dbContext)
        {
            _dBContext = dbContext;
        }
        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dBContext.Usuarios.AddAsync(usuario);
            _dBContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para ID:{id} não foi encontrado noa banco de dados.");
            }

            _dBContext.Usuarios.Update(usuarioPorId);
            await _dBContext.SaveChangesAsync();

            return true;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para ID:{id} não foi encontrado noa banco de dados.");
            }

            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Email = usuario.Email;
            usuarioPorId.Senha = usuario.Senha;

            _dBContext.Usuarios.Update(usuarioPorId);
            await _dBContext.SaveChangesAsync();

            return usuarioPorId;
        }

        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            return await _dBContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dBContext.Usuarios.ToListAsync();
        }
    }
}
