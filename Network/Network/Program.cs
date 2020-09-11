
using System;

namespace Network
{
    class Program
    {
        static void Main(string[] args)
        {
            /*         
                    GlobalServer.StartServer();
                    Console.ReadLine();
                    GlobalServer.handle_clients(1);
                    Console.ReadLine();
                    GlobalServer.broadcast("broadcast message");
                    Console.ReadLine(); */
            PrivateServer.StartListening();
            Console.ReadLine();
        }
    }
}
