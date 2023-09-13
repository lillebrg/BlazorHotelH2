namespace DomainModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int PersonCount { get; set; }
        public Address? Address { get; set; }
        public List<Booking>? Bookings { get; set; }
        public CreditCardInfo? CreditCardInfo { get; set; }
    }
}
