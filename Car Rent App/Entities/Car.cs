using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rent_App.Entities
{
    internal class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public bool isAvailable { get; set; }

    }
}
