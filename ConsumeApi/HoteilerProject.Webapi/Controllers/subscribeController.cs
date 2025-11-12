using HoteilerProject.BusinessLayer.Abstract;
using HoteilerProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HoteilerProject.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class subscribeController : ControllerBase
    {
        private readonly ISubscribeService _SubscribeService;

        public subscribeController(ISubscribeService SubscribeService)
        {
            _SubscribeService = SubscribeService;
        }

        [HttpGet]
        public IActionResult GetSubscribe()
        {
            var values = _SubscribeService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe Subscribe)
        {
            _SubscribeService.TAdd(Subscribe);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe Subscribe)
        {
            _SubscribeService.TUpdate(Subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _SubscribeService.TGetById(id);
            _SubscribeService.TDelete(values);


            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBySubscribe(int id)
        {
            var values = _SubscribeService.TGetById(id);
            return Ok(values);
        }
    }
}
