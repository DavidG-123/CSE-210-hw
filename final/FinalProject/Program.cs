using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mega Chatrooms(tm)\n");
        
        string hostName = Dns.GetHostName();
        IPAddress[] localIPs = Dns.GetHostAddresses(hostName);
        
        
        TcpListener server = new TcpListener(IPAddress.Any, 9999);  
        // we set our IP address as server's address, and we also set the port: 9999
        
        server.Start();  // this will start the server

        string compileMessage1 = "";

        while (true)   //we wait for a connection
        
        {
            TcpClient client = server.AcceptTcpClient();  //if a connection exists, the server will accept it
            NetworkStream ns = client.GetStream(); //networkstream is used to send/receive messages
            IPEndPoint remoteEndPoint = (IPEndPoint)client.Client.RemoteEndPoint;
            //byte[] hello = new byte[100];   //any message must be serialized (converted to byte array)
            //hello = Encoding.Default.GetBytes("hello world");  //conversion string => byte array
            //ns.Write(hello, 0, hello.Length);     //sending the message
            while (client.Connected)  //while the client is connected, we look for incoming messages
            {
                byte[] msg = new byte[1024];     //the messages arrive as byte array
                ns.Read(msg, 0, msg.Length);   //the same networkstream reads the message sent by the client
                var encoding = Encoding.UTF8;
                compileMessage1 += encoding.GetString(msg);
                foreach (var g in compileMessage1) {
                    if (g == (char)10) {
                        Console.WriteLine($"<{remoteEndPoint}> {compileMessage1}");
                        compileMessage1 = "";
                    }
                }
                byte[] response = new byte[1024];
                string plainText = Console.ReadLine();
                response = Encoding.Default.GetBytes(plainText);
                ns.Write(response, 0, response.Length);
            }
        }
    }
}

class ServTCP
{

}