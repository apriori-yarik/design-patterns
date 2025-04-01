using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class TCPListen : ITCPState
    {
        public void Acknowledge()
        {
            Console.WriteLine("State: Listen, ACK");
        }

        public void Close()
        {
            Console.WriteLine("State: Listen, Close");
        }

        public void Open()
        {
            Console.WriteLine("State: Listen, Open");
        }
    }
}
