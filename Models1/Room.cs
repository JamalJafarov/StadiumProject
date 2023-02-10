using System;
using System.Collections.Generic;

namespace StadiumProject.Models1
{
    public partial class Room
    {
        public Room()
        {
            ReservationToRooms = new HashSet<ReservationToRoom>();
        }

        public int Id { get; set; }
        public string RoomNumber { get; set; } = null!;
        public string Capacity { get; set; } = null!;

        public virtual ICollection<ReservationToRoom> ReservationToRooms { get; set; }
    }
}
