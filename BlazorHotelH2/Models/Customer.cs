using System.ComponentModel.DataAnnotations;

namespace BlazorHotelH2.Models
{
    public class Customer
    {
        [Key]
        public int customerId { get; set; }
        public string customerName { get; set; } = null!;
        public string address { get; set; } = null!;
        public List<Booking>? bookings { get; set; }
        public string creditCardInfo { get; set; } = null!;
        public int personCount { get; set; }
    }
}
