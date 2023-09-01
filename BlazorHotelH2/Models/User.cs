using System.ComponentModel.DataAnnotations;

namespace BlazorHotelH2.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        public string userName { get; set; } = null!;
        public string password { get; set; } = null!;
        public string email { get; set; } = null!;
        public Administrator? administrators { get; set; }
        public Customer? customers { get; set; }

        //lav liste af customer og admins i stedet for parent child class
    }
}
