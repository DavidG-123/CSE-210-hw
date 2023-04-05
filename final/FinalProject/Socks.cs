using System;
using System.Net;
using System.Net.Sockets;

class Socks
{
    static string hostName = Dns.GetHostName();
    IPAddress[] localIPs = Dns.GetHostAddresses(hostName);
}

class TheStatic
{

}