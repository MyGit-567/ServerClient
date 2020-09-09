
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Network;

namespace Client1
{
    class PrivateConnection
    {      
        public static void ClientConnection()
        {
            byte[] bytes = new byte[1024];
            IPAddress ipAddress = IPAddress.Parse("10.1.0.12");           
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);
            Socket sender = new Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp);
            sender.Connect(remoteEP);
            Console.WriteLine("Socket connected to {0}",
                            sender.RemoteEndPoint.ToString());

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Guid id = Guid.NewGuid(); //client can be only in one conversation
            int bytesSent = sender.Send(id.ToByteArray());
            Console.WriteLine($"send {bytesSent} bytes and their value is {id}");

            Console.Write("enter the username you want to talk with him: ");
            string userInput = Console.ReadLine();
            Guid id2 = new Guid(userInput);
            bytesSent = sender.Send(id2.ToByteArray());

            var task = Task.Factory.StartNew(obj =>
                {
                    while (true)
                    {
                        int bytesRec = ((Socket)obj).Receive(bytes);
                        Console.WriteLine("Echoed test = {0}",
                        Encoding.ASCII.GetString(bytes, 0, bytesRec));
                    }
                    //sender.Shutdown(SocketShutdown.Both);
                }, sender
                );

            while (true)
            {
                Console.Write("enter massage: ");
                userInput = Console.ReadLine();
                byte[] msg = Encoding.ASCII.GetBytes(userInput);
                bytesSent = sender.Send(msg);

            }


        }
    }
}
