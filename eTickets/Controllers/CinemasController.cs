using eTickets.Models;
using eTickets.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private ICinemaServices services;
        public CinemasController(ICinemaServices services)
        {
            this.services = services;
        }
        public IActionResult Index()
        {
            List<Cinema> cinemas=services.GetAll();
            return View(cinemas);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cinema cinema)
        {
            if (ModelState.IsValid)
            {
               services.Add(cinema);
                return RedirectToAction("Index");
            }
            return View(cinema);

        }

    }
}
