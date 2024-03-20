using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class Car
    {
        // for the sake of simplicity, we will work with public properties
        public int Seats { get; set; }
        public string Engine { get; set; }
        public string TripComputer { get; set; }
        public bool Autopilot { get; set; } = false;
    }
}
