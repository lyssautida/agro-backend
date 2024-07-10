using agro_models.Models;

namespace agro_backend.Repositories.Interfaces
{
    public interface ITalhaoRepository
    {
        Task<List<TalhaoModel>> BuscarTodosTalhoes();
        Task<TalhaoModel> BuscarPorId(int id);
        Task<TalhaoModel> Adicionar(TalhaoModel talhao);
        Task<TalhaoModel> Atualizar(TalhaoModel talhao, int id);
        Task<bool> Apagar(int id);
    }
}
