using eTickets.Models;
using eTickets.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private IActorServices services;
        public ActorsController(IActorServices services)
        {
            this.services = services;
        }
        public IActionResult Index()
        {
            List<Actor> actors = services.GetAll();
            return View(actors);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Actor actor)
        {
            if(ModelState.IsValid)
            {
                services.Add(actor);
                return RedirectToAction("Index");   
            }
            return View(actor);

        }
    }
}
