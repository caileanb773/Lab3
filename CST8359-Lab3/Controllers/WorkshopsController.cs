using CST8359_Lab3.Data;
using CST8359_Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace CST8359_Lab3.Controllers
{
    public class WorkshopsController : Controller
    {
        // step 6: replace in-memory Rsvp list with dbcontext
        private readonly ApplicationDbContext _context;

        // pass dbcontext to constructor
        public WorkshopsController(ApplicationDbContext context)
        {
            _context = context;
        }
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
            _context.RsvpDbSet.Add(rsvp);
            _context.SaveChanges();

            ViewData["Message"] = $"Thanks for registering, {rsvp.FullName}!";
            return View(rsvp);
        }

        public IActionResult Registrations()
        {
            return View(_context.RsvpDbSet.ToList());
        }
    }
}
