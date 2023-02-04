using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumProject.Models
{
    public class ReservationToRoom
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
    }
}
