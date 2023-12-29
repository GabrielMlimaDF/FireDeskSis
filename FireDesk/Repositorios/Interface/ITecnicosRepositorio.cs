using FireDesk.Models;

namespace FireDesk.Repositorios.Interface
{
    public interface ITecnicosRepositorio
    {
        Task<List<TecnicosModel>> GetAll();

        Task<TecnicosModel> GetId(int id);

        Task<TecnicosModel> Update(TecnicosModel model, int id);

        Task<TecnicosModel> Delete(int id);

        Task<TecnicosModel> Create(TecnicosModel model);
    }
}