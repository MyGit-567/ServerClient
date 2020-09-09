
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Client2
{
    class PrivateConnect
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
            while (true)
            {
                
                Console.Write("enter massage: ");
                string userInput = Console.ReadLine();
                byte[] msg = Encoding.ASCII.GetBytes(userInput);
                var task = Task.Factory.StartNew(obj =>
                {

                    int bytesSent = ((Socket)obj).Send(msg);
                    int bytesRec = ((Socket)obj).Receive(bytes);
                    Console.WriteLine("Echoed test = {0}",
                     Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    
                }, sender
                );
                //task.Wait();
            }
        }
    }
}
