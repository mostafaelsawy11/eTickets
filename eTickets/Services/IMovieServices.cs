using eTickets.Models;

namespace eTickets.Services
{
    public interface IMovieServices
    {
        List<Movie> GetAll();
        Actor GetbyId(int id);
        void Add(Movie movie);
        void update(int id, Movie movie);
        void Delete(int id);
    }
}
