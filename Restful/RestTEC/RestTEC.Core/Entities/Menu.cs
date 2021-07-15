using System;
using System.Collections.Generic;

#nullable disable

namespace RestTEC.Core.Entities
{
    public partial class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Calories { get; set; }
        public string Type { get; set; }
    }
}
