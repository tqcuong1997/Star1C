using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten Host: ");
            string host = Console.ReadLine();
            IPHostEntry iphe = Dns.GetHostEntry(host);
            Console.WriteLine("Ten: ", host);
            foreach(IPAddress ip in Dns.GetHostAddresses("google.com"))
            {
                Console.WriteLine(ip.ToString());
            }
        }
    }
}
