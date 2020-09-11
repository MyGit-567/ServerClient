
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Network
{
    public class PrivateServer
    {
        public static void StartListening()
        {
            Dictionary<Guid, Socket> allsocket = new Dictionary<Guid, Socket>();

            IPAddress ipAddress = IPAddress.Parse("10.1.0.12");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);
            Socket listener = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(localEndPoint);
            listener.Listen(10);

            while (true)
            {             
                Socket handler = listener.Accept();
                byte[] bytes = new Byte[16];
                int bytesRec = ((Socket)handler).Receive(bytes);
                Guid id = new Guid(bytes); //client id
                allsocket.Add(id, handler);             
                int bytesReceive = ((Socket)handler).Receive(bytes);
                Guid idtosend = new Guid(bytes); //other client - to send him the message

                var task = Task.Factory.StartNew(newhandler =>              
                {
                    while (true)
                    {
                        byte[] bytes = new Byte[1024];
                        string data = null;
                        int bytesRec = ((Socket)newhandler).Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        Console.WriteLine("text received : {0}", data);
                        byte[] msg = Encoding.ASCII.GetBytes(data);
                        allsocket[idtosend].Send(bytes);
                        Console.WriteLine(bytes);
                        ((Socket)newhandler).Send(msg);
                    }                    
                }, handler
                );
            }
        }
    }
}
