using System;
using System.Collections.Generic;

namespace StadiumProject.Models1
{
    public partial class Reservation
    {
        public Reservation()
        {
            ReservationToRooms = new HashSet<ReservationToRoom>();
        }

        public int Id { get; set; }
        public DateTime GameDate { get; set; }
        public int NumberOfRooms { get; set; }
        public int CustomerId { get; set; }
        public int StadiumId { get; set; }

        public virtual ICollection<ReservationToRoom> ReservationToRooms { get; set; }
    }
}
