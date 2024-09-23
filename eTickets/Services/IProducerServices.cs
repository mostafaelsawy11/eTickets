using eTickets.Models;

namespace eTickets.Services
{
    public interface IProducerServices
    {
        List<Producer> GetAll();
        Actor GetbyId(int id);
        void Add(Producer producer);
        void update(int id, Producer producer);
        void Delete(int id);
    }
}
