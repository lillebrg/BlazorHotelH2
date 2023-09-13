using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions options) : base(options) { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<CreditCardInfo> CreditCardInfo { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<Room> Room { get; set; }
    }
}
