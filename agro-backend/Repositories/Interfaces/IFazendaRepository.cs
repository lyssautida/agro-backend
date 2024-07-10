using agro_backend.Models;

namespace agro_backend.Repositories.Interfaces
{
    public interface IFazendaRepository
    {
        Task<List<FazendaModel>> BuscarTodasFazendas();
        Task<FazendaModel> BuscarPorId(int id);
        Task<FazendaModel> Adicionar(FazendaModel fazenda);
        Task<FazendaModel> Atualizar(FazendaModel fazenda, int id);
        Task<bool> Apagar(int id);
    }
}
