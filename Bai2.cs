using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("IP Address: ");
            string ip = Console.ReadLine();
            IPHostEntry iphe = Dns.Resolve(ip);
            Console.WriteLine("IP Address: "+ ip);
            Console.WriteLine("Host: "+ iphe.HostName);
        }
    }
}
