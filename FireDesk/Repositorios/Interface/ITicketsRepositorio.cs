using FireDesk.Models;

namespace FireDesk.Repositorios.Interface
{
    public interface ITicketsRepositorio
    {
       Task <List<TicketsModel>> GetAll();
        Task<List<TicketsModel>> GetId(int id);
    }
}
