using agro_backend.Data;
using agro_backend.Repositories.Interfaces;
using agro_models.Models;
using Microsoft.EntityFrameworkCore;

namespace agro_backend.Repositories
{
    public class TalhaoRepository : ITalhaoRepository
    {
        private readonly AgroDBContext _dBContext;

        public TalhaoRepository(AgroDBContext dbContext)
        {
            _dBContext = dbContext;
        }
        public async Task<TalhaoModel> Adicionar(TalhaoModel talhao)
        {
            await _dBContext.Talhoes.AddAsync(talhao);
            _dBContext.SaveChangesAsync();

            return talhao;
        }

        public async Task<bool> Apagar(int id)
        {
            TalhaoModel talhaoPorId = await BuscarPorId(id);

            if (talhaoPorId == null)
            {
                throw new Exception($"Talhão ID:{id} não foi encontrado no banco de dados.");
            }

            _dBContext.Talhoes.Update(talhaoPorId);
            await _dBContext.SaveChangesAsync();

            return true;
        }

        public async Task<TalhaoModel> Atualizar(TalhaoModel talhao, int id)
        {
            TalhaoModel talhaoPorId = await BuscarPorId(id);

            if (talhaoPorId == null)
            {
                throw new Exception($"Talhão para ID:{id} não foi encontrado no banco de dados.");
            }

            talhaoPorId.Nome = talhao.Nome;
            talhaoPorId.Coordenadas = talhao.Coordenadas;
            talhaoPorId.FazendaId = talhao.FazendaId;
            talhaoPorId.AtualizadoEm = talhao.AtualizadoEm;
            talhaoPorId.InativadoEm = talhao.InativadoEm;

            _dBContext.Talhoes.Update(talhaoPorId);
            await _dBContext.SaveChangesAsync();

            return talhaoPorId;
        }

        public async Task<TalhaoModel> BuscarPorId(int id)
        {
            return await _dBContext.Talhoes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<TalhaoModel>> BuscarTodosTalhoes()
        {
            return await _dBContext.Talhoes.ToListAsync();
        }
    }
}
