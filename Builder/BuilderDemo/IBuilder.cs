using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public interface IBuilder
    {
        public void Reset();
        public void SetSeats(int number);
        public void SetEngine(string engine);
        public void SetTripComputer(string tripComputer);
        public void SetAutopilot();
    }
}
