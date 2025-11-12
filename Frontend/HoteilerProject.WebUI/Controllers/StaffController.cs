using HoteilerProject.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HoteilerProject.WebUI.Controllers
{
    public class StaffController : Controller
    {private readonly IHttpClientFactory _httpClientFactory;

        public StaffController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5195/api/Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var Json=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<StaffWithModel>>(Json);
                return View(values);
            }
            

            return View();
        }
    }
}
