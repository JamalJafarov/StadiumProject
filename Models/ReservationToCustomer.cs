using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumProject.Models
{
    public class ReservationToCustomer
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
