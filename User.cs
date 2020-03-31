using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace WaterMeterSync
{
    class User
    {
        public TcpClient client { get; private set; }
        public BinaryReader rs { get; private set; }
        public BinaryWriter ws { get; private set; }
        public string userName { get; set; }
        public string connAdd { get; set; }
        public string connStu { get; set; }
        public DateTime actime { get; set; }
        public User(TcpClient client)
        {
            this.client = client;
            NetworkStream networkstream = client.GetStream();
            rs = new BinaryReader(networkstream);
            ws = new BinaryWriter(networkstream);
        }

        public void Close()
        {
                
                client.Client.Close();
                client.Close();
        }

    }
}
