using System;
using System.Net;
using System.Net.Sockets;

public abstract class Socks
{
    public string hostName = Dns.GetHostName();
    public abstract IPAddress[] localIPs();
}