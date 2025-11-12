using HoteilerProject.BusinessLayer.Abstract;
using HoteilerProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HoteilerProject.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomservice _RoomService;

        public RoomController(IRoomservice roomService)
        {
            _RoomService = roomService;
        }

        [HttpGet]
        public IActionResult GetRoom()
        {
            var values = _RoomService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(Room Room)
        {
            _RoomService.TAdd(Room);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room Room)
        {
            _RoomService.TUpdate(Room);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var values = _RoomService.TGetById(id);
            _RoomService.TDelete(values);


            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetByRoom(int id)
        {
            var values = _RoomService.TGetById(id);
            return Ok(values);
        }

    }
}
