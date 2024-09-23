using eTickets.Models;

namespace eTickets.Services
{
    public class ActorServices : IActorServices
    {
        private AppDbContext context;
        public ActorServices(AppDbContext context) {
            this.context = context;
        }
        public void Add(Actor actor)
        {
            context.Actors.Add(actor);  
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Actor> GetAll()
        {
            List<Actor> actors = context.Actors.ToList();
            return actors;
        }

        public Actor GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public void update(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
