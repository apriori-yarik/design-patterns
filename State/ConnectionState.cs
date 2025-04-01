using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public enum ConnectionState
    {
        TCPListen,
        TCPEstablished,
        TCPClosed
    }
}
