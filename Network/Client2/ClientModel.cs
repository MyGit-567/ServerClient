using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Network
{
    public class FirstClient
    {
        public string username { get; set; }
        public Socket handler { get; set; }
        public Guid ID { get; set; }

        public FirstClient(string UserName, Socket Handler)
        {
            username = UserName;
            handler = Handler;
        }
    }
}
