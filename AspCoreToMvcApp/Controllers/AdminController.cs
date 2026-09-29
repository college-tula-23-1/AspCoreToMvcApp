using Microsoft.AspNetCore.Mvc;

namespace AspCoreToMvcApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
