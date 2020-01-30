namespace Supermarket.Domain.Models
{
    public class Seat
    {
        public int id{get; set; }
        public int x{get; set; }
        public int y{get; set; }
        public Salon salon{get; set; }
        public int salonId{get; set; }
    }
}