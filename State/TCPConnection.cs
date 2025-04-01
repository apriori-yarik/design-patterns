using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class TCPConnection
    {
        private ITCPState tcpState;

        public TCPConnection(ConnectionState connectionState)
        {
            ChangeStateImpl(connectionState);
        }

        public void ChangeState(ConnectionState connectionState)
        {
            ChangeStateImpl(connectionState);
        }

        public void Close()
        {
            tcpState.Close();
        }

        public void Acknowledge()
        {
            tcpState.Acknowledge(); 
        }

        public void Open()
        {
            tcpState.Open();
        }

        private void ChangeStateImpl(ConnectionState newState)
        {
            switch (newState)
            {
                case ConnectionState.TCPListen:
                    tcpState = new TCPListen();
                    break;
                case ConnectionState.TCPEstablished:
                    tcpState = new TCPEstablished();
                    break;
                case ConnectionState.TCPClosed:
                    tcpState = new TCPClosed();
                    break;
                default:
                    break;
            }
        }
    }
}
