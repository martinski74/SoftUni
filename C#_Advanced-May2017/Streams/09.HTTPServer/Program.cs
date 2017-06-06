using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace _09.HTTPServer
{
    class Program
    {
        private const int Port = 8080;
        static void Main()
        {
            var listener = new TcpListener(IPAddress.Any, Port);
            listener.Start();
            Console.WriteLine($"Listening on port {Port}...");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());

                try
                {
                    string request = sr.ReadLine();
                    Console.WriteLine(request);

                    string[] tokens = request.Split(' ');
                    string page = tokens[1];

                    if (page == "/")
                    {
                        page = "/index.html";
                    }
                    
                    StreamReader file = new StreamReader("../../" + page);
                    sw.WriteLine("HTTP/1.0 200 OK\n");

                    string data = file.ReadLine();
                    while (data != null)
                    {
                        sw.WriteLine(data);
                        sw.Flush();
                        data = file.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    sw.WriteLine("<H1>ERROR!</H1>");
                    sw.Flush();

                }
                client.Close();

            }

        }
    }
}
