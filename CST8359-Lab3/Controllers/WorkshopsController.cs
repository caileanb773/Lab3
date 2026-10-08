using CST8359_Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

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
            ViewData["Message"] = $"Thanks for registering, {rsvp.FullName}!";
            return View(rsvp);
        }

        public IActionResult Registrations()
        {
            return View();
        }
    }
}
