using System;
using System.Collections.Generic;

namespace StadiumProject.Models1
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Surname { get; set; }
        public string PhoneNumber { get; set; } = null!;

    }
}
