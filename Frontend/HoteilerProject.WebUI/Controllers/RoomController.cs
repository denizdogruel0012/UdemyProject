using HoteilerProject.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoteilerProject.WebUI.Controllers
{
    public class RoomController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = client.GetAsync("http://localhost:5195/api/Room").Result;
            if(responseMessage.IsSuccessStatusCode)
            {
                var Json=responseMessage.Content.ReadAsStringAsync().Result;
                var values = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RoomWithModel>>(Json);
                return View(values);
            }

            return View();
        }
    }
}
