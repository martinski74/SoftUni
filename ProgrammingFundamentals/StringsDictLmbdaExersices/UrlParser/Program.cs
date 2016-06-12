using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string url = Console.ReadLine();
        string protocol = "";
        string server = "";
        string resource = "";

        int protocolEndIndex = url.IndexOf("://");
        string serverAndRes = url;

        if (protocolEndIndex!= -1)
        {
            protocol = url.Substring(0,protocolEndIndex);
            serverAndRes = url.Substring(protocol.Length + 3,url.Length - protocol.Length-3);
        }
        int serverEndIndex = serverAndRes.IndexOf("/");
        if (serverEndIndex!= -1)
        {
            server = serverAndRes.Substring(0,serverEndIndex);
            resource = serverAndRes.Substring(server.Length+1,serverAndRes.Length-server.Length-1);

        }
        else
        {
            server = serverAndRes;
        }
        Console.WriteLine("[protocol] = \"{0}\"", protocol);
        Console.WriteLine("[server] = \"{0}\"", server);
        Console.WriteLine("[resource] = \"{0}\"", resource);
    }
}

