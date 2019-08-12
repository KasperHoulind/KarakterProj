using System;

namespace TCPserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Server(7);
            server.Start();
            Console.ReadLine();
        }
    }
}
