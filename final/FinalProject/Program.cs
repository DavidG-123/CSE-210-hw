using System;
using System.Net;
using System.Net.Sockets;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mega Chatrooms(tm)");
        
        string hostName = Dns.GetHostName();
        IPAddress[] localIPs = Dns.GetHostAddresses(hostName);
        
        foreach (IPAddress ipAdrress in localIPs) {
            
        }
    }
}