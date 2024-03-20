using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class CarBuilder : IBuilder
    {
        private Car car;

        public CarBuilder()
        {
            this.Reset();
        }

        public Car GetResult()
        {
            var result = this.car;
            this.Reset();
            return this.car;
        }

        public void Reset()
        {
            this.car = new Car();
        }

        public void SetAutopilot()
        {
            this.car.Autopilot = true;
        }

        public void SetEngine(string engine)
        {
            this.car.Engine = engine;
        }

        public void SetSeats(int number)
        {
            this.car.Seats = number;
        }

        public void SetTripComputer(string tripComputer)
        {
            this.car.TripComputer = tripComputer;
        }
    }
}
