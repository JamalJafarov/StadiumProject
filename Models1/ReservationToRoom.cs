using System;
using System.Collections.Generic;

namespace StadiumProject.Models1
{
    public partial class ReservationToRoom
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public int RoomId { get; set; }

        public virtual Reservation Reservation { get; set; } = null!;
        public virtual Room Room { get; set; } = null!;
    }
}
