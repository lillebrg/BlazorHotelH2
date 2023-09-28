namespace DomainModels
{
    public class Booking
    {
        public int Id { get; set; }
        public Room Room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
