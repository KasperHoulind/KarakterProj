using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace TCPclient
{
    class Client
    {
        public void Start()
        {
            var client = new TcpClient("localhost", 7);
            Console.WriteLine("Client er klar til brug\n" +
                              "Brug funktionen 'Konventer' for at Konventere karakterene til ECTS \n" +
                              "Brug funktionen 'Gennemsnit' for at udregne gennemsnit af karakterne");
            while (true)
            {
                var ns = client.GetStream();
                var sr = new StreamReader(ns);
                var sw = new StreamWriter(ns);

                sw.AutoFlush = true;

                sw.WriteLine(Console.ReadLine());
                Console.WriteLine(sr.ReadLine());
            }
        }
    }
}
