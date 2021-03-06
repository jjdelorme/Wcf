using System;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryServiceSolution.LibraryServiceClient client = null;
            if (args.Length > 0)
            {
                string address = "http://localhost:" + args[0] + "/LibraryService";
                client = new LibraryServiceSolution.LibraryServiceClient(
                    "LibraryService_EndPoint",
                    address);
            }
            else
            {
                Console.WriteLine("Error, must specify a port number.");
                Console.WriteLine("\texample: WcfClient 8888");
                return;
            }

            LibraryServiceSolution.Book book = client.SearchBook("Name 12");
            
            if (book != null)
            {
                Console.WriteLine("Connected to " + client.Endpoint.Address.ToString());
                Console.WriteLine("Book ID : " + book.ID);
            }
            else
            {
                Console.WriteLine("Nothing returned");
            }
        }
    }
}
