//1. namespace (projectName.folderName)
//2. public class
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}