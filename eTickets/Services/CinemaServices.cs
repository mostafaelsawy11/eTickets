using eTickets.Models;

namespace eTickets.Services
{
    public class CinemaServices : ICinemaServices
    {
        private AppDbContext context;
        public CinemaServices(AppDbContext context) {
            this.context = context;
        }

        public void Add(Cinema cinema)
        {
             context.Cinemas.Add(cinema);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cinema> GetAll()
        {
            List<Cinema> cinemas = context.Cinemas.ToList();
            return cinemas;
        }

        public Actor GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public void update(int id, Cinema cinema)
        {
            throw new NotImplementedException();
        }
    }
}
