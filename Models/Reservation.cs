using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumProject.Models
{
    public class Reservation
    {

        public int Id { get; set; }
        public DateTime? GameDate { get; set; }
        public string? Time { get; set; }

        public int NumberOfRooms { get; set; }

        public virtual List<ReservationToCustomer> ReservationToCustomers { get; set; }

        public virtual List<ReservationToStadium> ReservationToStadiums { get; set; }

        public virtual List <ReservationToRoom> ReservationToRooms { get; set; }

        public virtual List<Stadium> Stadiums { get; set;}
        public virtual List<Room> Rooms { get; set; }
        public virtual List<Customer> Customers { get; set; }
       
    }
}
