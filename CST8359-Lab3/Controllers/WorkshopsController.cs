using Microsoft.AspNetCore.Mvc;

namespace CST8359_Lab3.Controllers
{
    public class WorkshopsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
