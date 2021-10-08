using System;
using System.Collections.Generic;

#nullable disable

namespace IS531_DonutsProject.Models
{
    public partial class Donut
    {
        public int DonutId { get; set; }
        public string DonutName { get; set; }
        public double? Price { get; set; }
        public string Category { get; set; }
        public string DonutDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}