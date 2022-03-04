using System;
using System.Net;
using System.Net.Sockets;

namespace PortGrabber
{
    class Program
    {
        static void Main(string[] args)
        {
            var ipAddress = IPAddress.Parse("127.0.0.1");
            var portNumber = 9092;
            var endPoint = new IPEndPoint(ipAddress, portNumber);
            var server = new TcpListener(endPoint);
            server.Start();
            //var client = server.AcceptTcpClient();

            Console.WriteLine($"port {portNumber} opened.");
            _ = Console.ReadKey();

            server.Stop();
        }
    }
}
