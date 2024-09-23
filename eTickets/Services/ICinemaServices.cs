using eTickets.Models;

namespace eTickets.Services
{
    public interface ICinemaServices
    {
        List<Cinema> GetAll();
        Actor GetbyId(int id);
        void Add(Cinema cinema);
        void update(int id, Cinema cinema);
        void Delete(int id);

    }
}
