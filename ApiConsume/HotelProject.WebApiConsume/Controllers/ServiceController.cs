using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddService(Service Service)
        {
            _serviceService.TInsert(Service);
            return Ok(Service);
        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.TGetByID(id);
            _serviceService.TDelete(values);
            return Ok();

        }
        [HttpPut]
        public IActionResult UpdateService(Service Service)
        {
            _serviceService.TUpdate(Service);
            return Ok(Service);
        }

        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _serviceService.TGetByID(id);
            return Ok(values);
        }
    }
}
