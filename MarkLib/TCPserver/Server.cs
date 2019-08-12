using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using MarkLib;

namespace TCPserver
{
    public class Server
    {
        private int _port;

        public Server(int port)
        {
            _port = port;
        }

        public void Start()
        {
            var listener = new TcpListener(IPAddress.Loopback, _port);
            listener.Start();
            while (true)
            {
                var client = listener.AcceptTcpClient();
                Task.Run(() => DoClient(client));
            }


        }

        private void DoClient(TcpClient client)
        {
            Console.WriteLine("Afventer input fra Client. . .");
            while (client.Connected)
            {
                var ns = client.GetStream();
                var sr = new StreamReader(ns);
                var sw = new StreamWriter(ns);
                sw.AutoFlush = true;
                string[] incStrings;

                incStrings = sr.ReadLine().Split(' ');

                Karakter karakterBeregner = new Karakter();


                string beregningsType = incStrings[0];
                if (beregningsType == "Konventer")
                {
                    int karakter = int.Parse(incStrings[1]);
                    string Konveteringresult =
                        ($"Din konventerede karakter savre til {karakterBeregner.GetMark(karakter)} på ECTS skalaen");
                    System.Console.WriteLine(Konveteringresult);
                    sw.WriteLine(Konveteringresult);
                }

                else if (beregningsType == "Gennemsnit")
                {
                    int karakter2 = int.Parse(incStrings[1]);
                    string Konveteringsresult =
                        ($"Gennemsnittet af dine karaktere er: {karakterBeregner.GetMark(karakter2)} på 12 trins-skalaen"
                        );
                    Console.WriteLine(Konveteringsresult);
                    sw.WriteLine(Konveteringsresult);
                }

                sw.Flush();
            }
        }
    }
}