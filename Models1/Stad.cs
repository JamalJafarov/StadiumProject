using System;
using System.Collections.Generic;

namespace StadiumProject.Models1
{
    public partial class Stad
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Number { get; set; }
        public decimal Price { get; set; }

    }
}
