using System;
using Microsoft.Owin.Hosting;

namespace Owin1
{
    class Program
    {
        static void Main()
        {
            using (WebApp.Start<MyWebApp>("http://localhost:5002"))
            {
                Console.WriteLine("Server is running");
                Console.Read();
            }
        }
    }
}
