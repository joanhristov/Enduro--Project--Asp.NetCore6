namespace EnduroProject.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using EnduroProject.Services.Events.Models;

    public class EventsController : Controller
    {
        private readonly IEvent

        public EventsController(IEventService)
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
