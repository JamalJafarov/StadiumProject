using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumProject.Models
{
    public class Room
    {
        public int Id { get; set; }
        [MaxLength(100)]

        public string RoomNumber { get; set; } = null!;
        [MaxLength(100)]

        public string Capacity { get; set; }
    }
}
