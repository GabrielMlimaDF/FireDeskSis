using FireDesk.Models;

namespace FireDesk.Repositorios.Interface
{
    public interface ITicketsRepositorio
    {
       Task <List<TicketsModel>> GetAll();
    }
}
