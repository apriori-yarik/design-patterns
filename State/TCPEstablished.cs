using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class TCPEstablished : ITCPState
    {
        public void Acknowledge()
        {
            Console.WriteLine("State: Established, ACK");
        }

        public void Close()
        {
            Console.WriteLine("State: Established, Close");
        }

        public void Open()
        {
            Console.WriteLine("State: Established, Open");
        }
    }
}
