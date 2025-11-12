using Microsoft.AspNetCore.Mvc;

namespace HoteilerProject.WebUI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
