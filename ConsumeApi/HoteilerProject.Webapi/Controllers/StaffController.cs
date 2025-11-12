using HoteilerProject.BusinessLayer.Abstract;
using HoteilerProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HoteilerProject.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult GetStaff()
        {
            var values=_staffService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.TAdd(staff);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.TUpdate(staff);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var values=_staffService.TGetById(id);
            _staffService.TDelete(values);


            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetByStaff(int id)
        {
            var values = _staffService.TGetById(id);
            return Ok(values);
        }
    }
}
