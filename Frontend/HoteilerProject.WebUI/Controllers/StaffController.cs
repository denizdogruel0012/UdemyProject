using Microsoft.AspNetCore.Mvc;

namespace HoteilerProject.WebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
