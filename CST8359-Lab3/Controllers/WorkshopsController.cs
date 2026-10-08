using CST8359_Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace CST8359_Lab3.Controllers
{
    public class WorkshopsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Confirm(Rsvp rsvp)
        {
            return View();
        }

        public IActionResult Registrations()
        {
            return View();
        }
    }
}
