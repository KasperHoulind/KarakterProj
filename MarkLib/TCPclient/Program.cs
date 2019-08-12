using System;

namespace TCPclient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client TCPClient = new Client();

            TCPClient.Start();
            Console.ReadLine();
        }
    }
}
