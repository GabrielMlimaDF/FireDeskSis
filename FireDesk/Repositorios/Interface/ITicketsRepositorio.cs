using FireDesk.Models;

namespace FireDesk.Repositorios.Interface
{
    public interface ITicketsRepositorio
    {
        Task<List<TicketsModel>> GetAll();

        Task<TicketsModel> GetId(int id);

        Task<TicketsModel> UpdateTickets(TicketsModel model, int id);

        Task<TicketsModel> DeleteTickets(int id);

        Task<TicketsModel> CreateTickets(TicketsModel model);
    }
}