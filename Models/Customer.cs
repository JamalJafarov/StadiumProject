using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [MaxLength(250)]
        public string? Surname { get; set; }
        [MaxLength(250)]
        public string PhoneNumber { get; set; } = null!;
        public int Count { get; set; }

    }
}
