using Microsoft.AspNetCore.Mvc;
using Booking.Models;
using System;
using Booking.Services;
namespace src.Controllers
{
    [Route("salons")]
    [ApiController]
    public class SalonController : ControllerBase
    {
        public SalonService salonService ;
        public SalonController(SalonService salonService){
            this.salonService = salonService;
        }
        
        [HttpPost]
        public IActionResult Create([FromBody]Salon newSalon){
            int error = salonService.createSalon(newSalon);
            if (error == 0){
                return BadRequest();
            }
            return Ok();
        }
    }
}