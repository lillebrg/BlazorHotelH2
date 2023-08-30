using System.ComponentModel.DataAnnotations;

namespace BlazorHotelH2.Models
{
    public class Booking
    {
        [Key]
        public int bookingId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

    }
}
