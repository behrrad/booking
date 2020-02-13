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
            if (error == 400){
                return BadRequest();
            }
            else if (error == 200){
                return Ok();
            }
            return NotFound();
        }
    }
    [Route("salons/{id}/seats")]
    public class SeatController : ControllerBase
    {
        public SeatService seatService  ;
        public SeatController(SeatService seatService){
            this.seatService = seatService;
        }
        
        [HttpPost]
        public IActionResult Create(int id, [FromBody]Seat seat){
            int error = seatService.CreateSeat(id, seat);
            if (error == 400){
                return BadRequest();
            }
            else if(error == 200){
                return Ok();
            }
            return NotFound();
        }
    }
}