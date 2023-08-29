namespace BlazorHotelH2.Models
{
    public class Customer : User
    {
        public string customerName { get; set; }
        public string address { get; set; }
        public List<Booking> bookings { get; set; }
        public string creditCardInfo { get; set; }
        public int personCount { get; set; }
    }
}
