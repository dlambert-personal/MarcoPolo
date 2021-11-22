using Microsoft.AspNetCore.Mvc;

namespace MarcoPoloAPI.Controllers
{
    public class MarcoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
