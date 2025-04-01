using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class TCPClosed : ITCPState
    {
        public void Acknowledge()
        {
            Console.WriteLine("State: Closed, ACK");
        }

        public void Close()
        {
            Console.WriteLine("State: Closed, Close");
        }

        public void Open()
        {
            Console.WriteLine("State: Closed, Open");
        }
    }
}
