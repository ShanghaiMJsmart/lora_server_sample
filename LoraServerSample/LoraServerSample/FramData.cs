using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoraServerSample
{
    public class FramData
    {
        /// <summary>
        /// DataUp/DataDown
        /// 分别表示上⾏／下⾏数据帧
        /// </summary>
        public string FrameType { get; set; }

        /// <summary>
        /// 16位⼗十六进制字符串
        /// 全球唯⼀一地址 
        /// </summary>
        public string DevEUI { get; set; }


        /// <summary>
        /// 整数，范围1～223
        /// 该数据帧发送到终端的哪⼀一个端⼝口
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// 终端收到该数据帧后是否需要给服务器器回复确认 
        /// </summary>
        public bool AckRequest { get; set; }

        /// <summary>
        /// 给终端回复确认以表明上⼀一帧数据已接收 
        /// </summary>
        public bool Ack { get; set; }

        /// <summary>
        /// ⼗六进制字符串
        /// 发送给终端的数据实体
        /// </summary>
        public string Data { get; set; }
    }

    public class UpFramData: FramData
    {

        /// <summary>
        /// 16位⼗十六进制字符串串
        /// 区分不不同类型产品，例例如，⻔门锁控制器器采⽤用同⼀一数值。 
        /// </summary>
        public string AppEUI { get; set; }

        /// <summary>
        /// 整数 
        /// 该节点的LoRaWAN网络地址 
        /// </summary>
        public int NetAddr { get; set; }

        /// <summary>
        /// 整数 
        /// 终端当前电源电压 
        /// </summary>
        public int Battery { get; set; }

        /// <summary>
        /// 整数
        /// 信号强度，越⼩小表示信号越差 
        /// </summary>
        public int Rssi { get; set; }

        /// <summary>
        /// 链路路质量
        /// </summary>
        public float Snr { get; set; }
    }
}
