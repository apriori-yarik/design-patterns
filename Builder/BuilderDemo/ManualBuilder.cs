using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class ManualBuilder : IBuilder
    {
        private Manual manual;

        public ManualBuilder()
        {
            this.Reset();
        }

        public Manual GetResult()
        {
            var result = this.manual;
            this.Reset();
            return result;
        }

        public void Reset()
        {
            this.manual = new Manual();
        }

        public void SetAutopilot()
        {
            this.manual.Text += "Autopilot ON\n";
        }

        public void SetEngine(string engine)
        {
            this.manual.Text += $"Engine: {engine}\n";
        }

        public void SetSeats(int number)
        {
            this.manual.Text += $"Seats: {number}\n";
        }

        public void SetTripComputer(string tripComputer)
        {
            this.manual.Text += $"Trip computer: {tripComputer}\n";
        }
    }
}
