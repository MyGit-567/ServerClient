
using System;

namespace Network
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Global chat");
            Console.WriteLine("2) Ptivate chat");

            switch (Console.ReadLine())
            {
                case "1":
                    GlobalServer.StartServer();
                    Console.ReadLine();
                    GlobalServer.handle_clients(1);
                    Console.ReadLine();
                    GlobalServer.broadcast("broadcast message");
                    Console.ReadLine();   */      
            
                    PrivateServer.StartListening();
                    Console.ReadLine();

        }
    }
}
