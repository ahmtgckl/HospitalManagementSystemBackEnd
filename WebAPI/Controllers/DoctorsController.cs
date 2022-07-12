using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {

        IDoctorService _doctorService;
        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpPost("add")]
        public IActionResult Add(Doctor doctor)
        {
            var resutl = _doctorService.Add(doctor);
            if (resutl.Success)
            {
                return Ok(resutl);
            }
            return BadRequest(resutl);
        }


        [HttpPost("update")]
        public IActionResult Update(Doctor doctor)
        {
            var result = _doctorService.Update(doctor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(Doctor doctor)
        {
            var result = _doctorService.Delete(doctor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _doctorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

































    }
}
