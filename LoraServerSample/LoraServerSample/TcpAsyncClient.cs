using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoraServerSample
{
    public class TcpAsyncClient
    {
        private Thread threadclient = null;
        private Socket socketclient = null;

        public TcpAsyncClient()
        {
            this.socketclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        internal string ConnectServer(string ip, int port)
        {
            //获取文本框中的IP地址  
            var address = IPAddress.Parse(ip);

            //将获取的IP地址和端口号绑定在网络节点上  
            var point = new IPEndPoint(address, port);

            try
            {
                //客户端套接字连接到网络节点上，用的是Connect  
                socketclient.Connect(point);
            }
            catch (Exception ex)
            {
                return "连接失败:" + ex.Message;
            }

            threadclient = new Thread(recv);
            threadclient.IsBackground = true;
            threadclient.Start();

            return "";
        }

        // 接收服务端发来信息的方法    
        private void recv()
        {
            //持续监听服务端发来的消息 
            while (true)
            {
                try
                {
                    //定义一个1M的内存缓冲区，用于临时性存储接收到的消息  
                    byte[] arrRecvmsg = new byte[1024 * 1024];

                    //将客户端套接字接收到的数据存入内存缓冲区，并获取长度  
                    int length = socketclient.Receive(arrRecvmsg);

                    //将套接字获取到的字符数组转换为人可以看懂的字符串  
                    var strRevMsg = Encoding.UTF8.GetString(arrRecvmsg, 0, length);

                    MessageBox.Show(strRevMsg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("远程服务器已经中断连接:" + ex.Message, "错误", MessageBoxButtons.OK);
                    break;
                }
            }
        }

        //发送字符信息到服务端的方法  
        internal void ClientSendMsg(string sendMsg)
        {
            //将输入的内容字符串转换为机器可以识别的字节数组     
            byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(sendMsg);
            //调用客户端套接字发送字节数组     
            socketclient.Send(arrClientSendMsg);
            //将发送的信息追加到聊天内容文本框中   
        }

        internal void Close()
        {
            threadclient.Abort();
            socketclient.Close();
        }
    }
}
