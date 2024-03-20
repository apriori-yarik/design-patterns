using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public static class Director
    {
        public static void ConstructSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine("SportEngine");
            builder.SetTripComputer("SportTripComputer");
            builder.SetAutopilot();
        }

        // other static methods constructing different types of cars can be added
    }
}
