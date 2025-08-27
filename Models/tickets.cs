using Microsoft.AspNetCore.Mvc;

namespace soft20181_starter.Models
{
    public class Tickets : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
