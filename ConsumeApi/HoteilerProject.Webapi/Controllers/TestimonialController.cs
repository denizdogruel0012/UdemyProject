using HoteilerProject.BusinessLayer.Abstract;
using HoteilerProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HoteilerProject.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _TestimonialService;

        public TestimonialController(ITestimonialService TestimonialService)
        {
            _TestimonialService = TestimonialService;
        }

        [HttpGet]
        public IActionResult GetTestimonial()
        {
            var values = _TestimonialService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial Testimonial)
        {
            _TestimonialService.TAdd(Testimonial);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial Testimonial)
        {
            _TestimonialService.TUpdate(Testimonial);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _TestimonialService.TGetById(id);
            _TestimonialService.TDelete(values);


            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetByTestimonial(int id)
        {
            var values = _TestimonialService.TGetById(id);
            return Ok(values);
        }
    }
}
