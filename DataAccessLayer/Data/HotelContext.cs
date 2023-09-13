using DomainModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer.Data
{
    public class HotelContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<CreditCardInfo> CreditCardInfo { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<Room> Room { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source = 192.168.148.128\\MSSQL; Initial Catalog = Group1HotelH2; User ID = group1user; Password = Qaz2wsx; Connect Timeout = 30; Encrypt = False;");
        }
    }
}
