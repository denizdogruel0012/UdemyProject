using Microsoft.AspNetCore.Mvc;

namespace HoteilerProject.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
