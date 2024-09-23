using eTickets.Models;
using eTickets.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private IMovieServices services;
        private ICinemaServices cinemaServices;
        private IProducerServices producerServices;
        public MoviesController(IMovieServices services, ICinemaServices cinemaServices,IProducerServices producerServices)
        {
            this.services = services;
            this.cinemaServices = cinemaServices;
            this.producerServices = producerServices;
        }
        public IActionResult Index()
        {
            List<Movie> movies =services.GetAll() ;
            return View(movies);
        }
        public IActionResult Create()
        {
            ViewData["cinema"] = cinemaServices.GetAll();
            ViewData["producer"] = producerServices.GetAll();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
               

                services.Add(movie);

                return RedirectToAction("Index");
            }
            ViewData["cinema"] = cinemaServices.GetAll();
            ViewData["producer"] = producerServices.GetAll();

            return View(movie);

        }
    }
}
