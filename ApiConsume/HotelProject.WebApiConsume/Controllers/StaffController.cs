using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
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
        public IActionResult StaffList()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStaff(Staff Staff)
        {
            _staffService.TInsert(Staff);
            return Ok(Staff);
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.TGetByID(id);
            _staffService.TDelete(values);
            return Ok();

        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff Staff)
        {
            _staffService.TUpdate(Staff);
            return Ok(Staff);
        }

        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values = _staffService.TGetByID(id);
            return Ok(values);
        }
    }
}
