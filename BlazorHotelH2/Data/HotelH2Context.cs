using BlazorHotelH2.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace BlazorHotelH2.Data
{
    public class HotelH2Context : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Administrator> Administrators { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!; 
        public DbSet<Booking> Bookings { get; set; } = null!;
        public DbSet<Room> Rooms { get; set; } = null!;
        public DbSet<Picture> Pictures { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LILLEBRG-LAP\\TECH2DB;Initial Catalog=HotelH2;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        }

    }
}
