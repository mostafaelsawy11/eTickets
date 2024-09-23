using eTickets.Models;
using eTickets.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private IProducerServices producerServices;
        public ProducersController(IProducerServices producerServices)
        {
            this.producerServices = producerServices;
        }
        public IActionResult Index()
        {
            List<Producer> producers = producerServices.GetAll();
            return View(producers);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Producer producer)
        {
            if (ModelState.IsValid)
            {
                producerServices.Add(producer);
                return RedirectToAction("Index");
            }
            return View(producer);

        }
    }
}
