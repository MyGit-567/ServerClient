
using System;

namespace Client1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateConnection.ClientConnection();
            Console.ReadLine();

            GlobalClient1.FirstClient();
            Console.ReadLine();

            //Program program = new Program();
            //Program.GetBytes("@SendFile/?path=C:/Code/ServerClient.search.jpg");
        }
    }
}
