using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoraServerSample
{
    public class AsyncEventArgs
    {
        /// <summary>  
        /// 提示信息  
        /// </summary>  
        public string msg;

        /// <summary>  
        /// 客户端状态封装类  
        /// </summary>  
        public TcpClientState state;

        /// <summary>  
        /// 是否已经处理过了  
        /// </summary>  
        public bool IsHandled { get; set; }

        public AsyncEventArgs(string msg)
        {
            this.msg = msg;
            IsHandled = false;
        }
        public AsyncEventArgs(TcpClientState state)
        {
            this.state = state;
            IsHandled = false;
        }
        public AsyncEventArgs(string msg, TcpClientState state)
        {
            this.msg = msg;
            this.state = state;
            IsHandled = false;
        }
    }
}