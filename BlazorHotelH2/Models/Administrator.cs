using System.ComponentModel.DataAnnotations;

namespace BlazorHotelH2.Models
{
    public class Administrator
    {
        [Key]
        public int adminId { get; set; }
        public string adminName { get; set; } = null!;
    }
}
