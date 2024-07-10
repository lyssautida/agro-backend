using agro_backend.Data;
using agro_backend.Models;
using agro_backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace agro_backend.Repositories
{
    public class FazendaRepository : IFazendaRepository
    {
        private readonly AgroDBContext _dBContext;

        public FazendaRepository(AgroDBContext dbContext)
        {
            _dBContext = dbContext;
        }
        public async Task<FazendaModel> Adicionar(FazendaModel fazenda)
        {
            await _dBContext.Fazendas.AddAsync(fazenda);
            _dBContext.SaveChangesAsync();

            return fazenda;
        }

        public async Task<bool> Apagar(int id)
        {
            FazendaModel fazendaPorId = await BuscarPorId(id);

            if (fazendaPorId == null)
            {
                throw new Exception($"Fazenda ID:{id} não foi encontrado no banco de dados.");
            }

            _dBContext.Fazendas.Update(fazendaPorId);
            await _dBContext.SaveChangesAsync();

            return true;
        }

        public async Task<FazendaModel> Atualizar(FazendaModel fazenda, int id)
        {
            FazendaModel fazendaPorId = await BuscarPorId(id);

            if (fazendaPorId == null)
            {
                throw new Exception($"Fazenda para ID:{id} não foi encontrado no banco de dados.");
            }

            fazendaPorId.Nome = fazenda.Nome;
            fazendaPorId.Coordenadas = fazenda.Coordenadas;
            fazendaPorId.UsuarioId = fazenda.UsuarioId;
            fazendaPorId.AtualizadoEm = fazenda.AtualizadoEm;
            fazendaPorId.InativadoEm = fazenda.InativadoEm;

            _dBContext.Fazendas.Update(fazendaPorId);
            await _dBContext.SaveChangesAsync();

            return fazendaPorId;
        }

        public async Task<FazendaModel> BuscarPorId(int id)
        {
            return await _dBContext.Fazendas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<FazendaModel>> BuscarTodasFazendas()
        {
            return await _dBContext.Fazendas.ToListAsync();
        }
    }
}
