using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Services
{
    public class MovieServices : IMovieServices
    {
        private AppDbContext context;
        public MovieServices(AppDbContext context) {
            this.context = context;
        }
        public void Add(Movie movie)
        {
           context.Movies.Add(movie);
        context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            List<Movie> movies = context.Movies.Include(n => n.Cinema).ToList();
            return movies;
        }

        public Actor GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public void update(int id, Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
