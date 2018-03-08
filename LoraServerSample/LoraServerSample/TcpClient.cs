using System;
using System.Net;
using System.Net.Sockets;

namespace LoraServerSample
{
    public class TcpClient
    {
        #region 初始化
        /// <summary>
        /// IP地址
        /// </summary>
        public IPAddress IP { get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        public int Port { get; set; }

        private Socket client;
        private byte[] buff = new byte[1024];
        public TcpClient()
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public TcpClient(IPAddress ip, int port)
        {
            this.IP = ip;
            this.Port = port;
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        #endregion

        #region 与服务器连接
        public void BeginConncet()
        {
            BeginConncet(this.IP, this.Port);
        }

        public void BeginConncet(IPAddress ip, int port)
        {
            client.BeginConnect(ip, port, new AsyncCallback(BeginConnectCallBack), client);
        }

        private void BeginConnectCallBack(IAsyncResult ar)
        {
            Socket tClient = ar as Socket;
            tClient.EndConnect(ar);
            //通知调用端连接成功
        }
        #endregion

        #region 发送数据
        public void BeginSendData(byte[] bytes)
        {
            if (client.Connected)
            {
                client.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, new AsyncCallback(BeginSendDataCallBack), client);
            }
        }

        private void BeginSendDataCallBack(IAsyncResult ar)
        {
            Socket tCleint = ar as Socket;
            tCleint.EndSend(ar);
            //通知调用端发送完毕
        }
        #endregion

        #region 接收数据
        public void BeginAccetpData()
        {
            if (client.Available > 0)
            {
                client.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(BeginReceiveCallBack), client);
            }
        }

        private void BeginReceiveCallBack(IAsyncResult ar)
        {
            var tClient = ar as Socket;
            tClient.EndReceive(ar);
            //通知调用端接收完毕
        }
        #endregion
    }
}
