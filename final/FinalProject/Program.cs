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
        
        server.Start();

        string compileMessage1 = "";

        while (true)
        
        {
            TcpClient client = server.AcceptTcpClient();
            NetworkStream ns = client.GetStream();
            IPEndPoint remoteEndPoint = (IPEndPoint)client.Client.RemoteEndPoint;
            
            while (client.Connected) 
            {
                byte[] msg = new byte[1024];
                ns.Read(msg, 0, msg.Length);
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