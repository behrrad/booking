using System;
namespace Supermarket.Domain.Models
{
    public class Show
    {
        public string title{get; set; }
        public DateTime startTime{get; set; }
        public DateTime endTime{get; set; }
        public string summary{get; set; }
        public int price {get; set; }
        public int id {get; set; }

        public Salon salon{get; set; }
        public int salonId{get; set; }

    }
}