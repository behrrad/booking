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
        public void createSalon(Salon salon){
            
            dbContext.salons.Add(salon); 
            dbContext.SaveChanges();   
        }
        
    }
}