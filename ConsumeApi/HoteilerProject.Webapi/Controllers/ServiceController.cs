using HoteilerProject.BusinessLayer.Abstract;
using HoteilerProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HoteilerProject.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly Iserviceservice _ServiceService;

        public ServiceController(Iserviceservice ServiceService)
        {
            _ServiceService = ServiceService;
        }

        [HttpGet]
        public IActionResult GetService()
        {
            var values = _ServiceService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddService(Service Service)
        {
            _ServiceService.TAdd(Service);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service Service)
        {
            _ServiceService.TUpdate(Service);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var values = _ServiceService.TGetById(id);
            _ServiceService.TDelete(values);


            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetByService(int id)
        {
            var values = _ServiceService.TGetById(id);
            return Ok(values);
        }
    }
}
