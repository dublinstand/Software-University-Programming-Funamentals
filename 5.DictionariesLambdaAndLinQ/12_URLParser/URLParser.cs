using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that parses an URL given in the following format:
//[protocol]://[server]/[resource]
//The parsing extracts its parts: protocol, server and resource.
//•	The[server] part is mandatory.
//•	The[protocol] and[resource] parts are optional.


class URLParser
{
    static void Main()
    {
        string url = Console.ReadLine();

        int protocolIndex = url.IndexOf("://");
        string protocol = "";

        if (protocolIndex != -1)
        {            
            protocol = url.Substring(0, protocolIndex);
        }

        int serverIndex = url.IndexOf("/", protocolIndex + 3);

        string server = "";

        string resource = "";

        if (serverIndex != -1)
        {
            resource = url.Substring(serverIndex + 1);
            server = url.Substring(protocolIndex + 3, serverIndex - protocolIndex - 3);
        }
        else
        {
            server = url;
        }

        Console.WriteLine("[protocol] = \"{0}\"", protocol);
        Console.WriteLine("[server] = \"{0}\"", server);
        Console.WriteLine("[resource] = \"{0}\"", resource);

    }
}

