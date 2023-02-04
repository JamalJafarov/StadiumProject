using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumProject.Models
{
    public class Stad:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5A83I97;Initial Catalog=StadiumDb;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Stadium> Stads { get; set; }
        public DbSet<ReservationToCustomer> ReservationToCustomers { get; set; }
        public DbSet<ReservationToStadium> ReservationToStadiums { get; set; }
        public DbSet<ReservationToRoom> ReservationToRooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
