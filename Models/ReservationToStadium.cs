using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumProject.Models
{
    public class ReservationToStadium
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public int StadiumId { get; set; }
        public virtual Stadium Stadium { get; set; }
    }
}
