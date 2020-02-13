using Booking.Models;
using Booking;
using System.Threading.Tasks;
using System.Linq;
using System;    
using System.Text; 
using Microsoft.EntityFrameworkCore;
namespace Booking.Services
{
    public class SeatService
    {
        public AppDbContext dbContext { get; set; }

        public SeatService (AppDbContext dbContext) { 
            this.dbContext = dbContext;
        }
        public int CreateSeat(int id, Seat seat){
            if(seat.Id != 0){
                return 400;
            }
            if(seat.X < 0){
                return 400;
            }
            if(seat.Y < 0){
                return 400;
            }
            Task<bool> search;
            search = dbContext.salons.AnyAsync(p => p.Id == id);
            search.Wait();
            if(!search.Result){
                return 404;
            }
            search = dbContext.seats.AnyAsync(p => p.X == seat.X && p.Y == seat.Y);
            search.Wait();
            if(search.Result){
                return 400;
            }
            seat.SalonId = id;
            dbContext.seats.Add(seat); 
            dbContext.SaveChanges();   
            return 200;
        }
    }  
}