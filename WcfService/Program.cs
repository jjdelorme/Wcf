using System;
using System.ServiceModel;

namespace LibraryServiceSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string port = Environment.GetEnvironmentVariable("PORT");
            if (string.IsNullOrEmpty(port))
            {
                port = "9999";
                Console.WriteLine("Using default port: " + port);
            }
            
            Uri baseAddress = new Uri($"http://localhost:{port}/LibraryService");
            ServiceHost server = new ServiceHost(typeof(LibraryService), baseAddress);
            server.Open();

            Console.WriteLine("Your service is started at " + baseAddress + "...");
            Console.ReadLine();

            server.Close();

        }
    }
}