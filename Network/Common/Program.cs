
using Network;
using System;
using System.Threading;

namespace Common
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello! Welcome to chat");
            Console.WriteLine("Choose one of the options: ");
            Console.WriteLine("1. global chat");
            Console.WriteLine("2. private chat");
            Console.WriteLine("\r\n Select an option: ");
            
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    GlobalServer.StartServer();
                    Console.ReadLine();
                    GlobalServer.handle_clients(1);
                    Console.ReadLine();
                    GlobalServer.broadcast("broadcast message");
                    Console.ReadLine();
                    break;
                    

                case "2":
                    PrivateServer.StartListening();
                    Console.ReadLine();
                    break;
            }

            
        }
    }
}
