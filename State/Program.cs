// See https://aka.ms/new-console-template for more information
using State;

TCPConnection tCPConnection = new TCPConnection(ConnectionState.TCPListen);
tCPConnection.Open();
tCPConnection.ChangeState(ConnectionState.TCPEstablished);
tCPConnection.Acknowledge();
tCPConnection.ChangeState(ConnectionState.TCPClosed);
tCPConnection.Close();

