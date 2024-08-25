using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers
{
    public class LongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}