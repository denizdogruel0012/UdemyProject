using Microsoft.AspNetCore.Mvc;

namespace HoteilerProject.WebUI.Controllers
{
    public class RoomController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public IActionResult Index()
        {
            return View();
        }
    }
}
