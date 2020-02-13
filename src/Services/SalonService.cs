using Booking.Models;
using Booking;
using System.Threading.Tasks;
using System.Linq;
using System;    
using System.Text; 
using Microsoft.EntityFrameworkCore;
namespace Booking.Services
{
    public class SalonService
    {
        public AppDbContext dbContext { get; set; }

        public SalonService (AppDbContext dbContext) { 
            this.dbContext = dbContext;
        }
        public int createSalon(Salon salon){
            if(salon.Id != 0){
                return 0;
            }
            else if(salon.SeatHeight <= 0){
                return 0;
            }
            else if(salon.SeatWidth <= 0){
                return 0;
            }
            else if(salon.Name.Length == 0){
                return 0;
            }
            dbContext.salons.Add(salon); 
            dbContext.SaveChanges();   
            return 1;
        }
        
    }
}