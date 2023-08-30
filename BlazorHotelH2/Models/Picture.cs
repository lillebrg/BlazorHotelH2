using System.ComponentModel.DataAnnotations;

namespace BlazorHotelH2.Models
{
    public class Picture
    {
        [Key]
        public int pictureId { get; set; }
        public string pictureName { get; set; } = null!;
        public string pictureUrl { get; set; } = null!;
    }
}
