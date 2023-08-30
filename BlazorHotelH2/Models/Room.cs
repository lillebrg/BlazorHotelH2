using System.ComponentModel.DataAnnotations;

namespace BlazorHotelH2.Models
{
    public class Room
    {
        [Key]
        public int roomId { get; set; }
        public string roomType { get; set; } = null!;
        public int price { get; set; }
        public bool vacancy { get; set; }
        public int maxPeople { get; set; }
        public List<Picture> pictures { get; set; } = null!;
    }
}
