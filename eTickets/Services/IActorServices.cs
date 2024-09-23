using eTickets.Models;

namespace eTickets.Services
{
    public interface IActorServices
    {
        List<Actor> GetAll();
        Actor GetbyId(int id);
        void Add(Actor actor);
        void update(int id, Actor actor);   
        void Delete(int id);
    }
}
