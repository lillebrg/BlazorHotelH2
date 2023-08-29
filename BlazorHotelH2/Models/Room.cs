namespace BlazorHotelH2.Models
{
    public class Room
    {
        public int roomId { get; set; }
        public string roomType { get; set; }
        public int price { get; set; }
        public bool vacancy { get; set; }
        public int maxPeople { get; set; }
        public List<string> pictures { get; set; }
    }
}
