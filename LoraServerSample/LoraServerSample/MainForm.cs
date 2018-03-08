using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoraServerSample
{
    public partial class MainForm : Form
    {
        private TcpAsyncServer asyncTCPServer = null;
        private TcpAsyncClient tcpAsyncClient = null;
        static System.Timers.Timer _timer = new System.Timers.Timer();

        public MainForm()
        {
            InitializeComponent();
            _timer.Elapsed += _timer_Elapsed;
            this.Size = new Size(820, 480);
            tcpAsyncClient = new TcpAsyncClient();
        }

        #region[连接/监听]
        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConect_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var ip = tbxIp.Text;
            var port = tbxPort.Text;

            #region
            if (string.IsNullOrWhiteSpace(ip))
            {
                MessageBox.Show("请输入服务IP！", "提示", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(port))
            {
                MessageBox.Show("请输入服务端口！", "提示", MessageBoxButtons.OK);
                return;
            }
            #endregion

            if (cmbType.SelectedItem.ToString() == "服务端")
            {
                ScoketServerProce(btn.Text, int.Parse(port));
            }
            else if (cmbType.SelectedItem.ToString() == "客户端")
            {
                ClientProce(btn.Text, ip, int.Parse(port));
            }
        }

        /// <summary>
        /// 服务端监听
        /// </summary>
        /// <param name="conType"></param>
        private void ScoketServerProce(string conType, int port)
        {
            if (conType == "连接")
            {
                #region
                this.asyncTCPServer = new TcpAsyncServer(port);
                this.asyncTCPServer.DataReceived += AsyncTCPServer_DataReceived;
                this.asyncTCPServer.Start();

                this.tbxIp.Enabled = false;
                this.tbxPort.Enabled = false;
                btnConect.Text = "断开";
                #endregion
            }
            else
            {
                asyncTCPServer.Stop();

                tbxIp.Enabled = true;
                tbxPort.Enabled = true;
                btnConect.Text = "连接";
            }
        }

        /// <summary>
        /// 客户端处理
        /// </summary>
        /// <param name="conType"></param>
        private void ClientProce(string conType, string ip, int port)
        {
            if (conType == "连接")
            {
                var errInFo = tcpAsyncClient.ConnectServer("127.0.0.1", 3333);

                if (string.IsNullOrWhiteSpace(errInFo))
                {
                    this.tbxIp.Enabled = false;
                    this.tbxPort.Enabled = false;
                    btnConect.Text = "断开";
                }
                else
                {
                    MessageBox.Show(errInFo, "错误", MessageBoxButtons.OK);
                }
            }
            else
            {
                tcpAsyncClient.Close();

                tbxIp.Enabled = true;
                tbxPort.Enabled = true;
                btnConect.Text = "连接";
            }
        }
        #endregion

        /// <summary>
        /// 定时发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            var opertype = btnSend.Text;
            var loop = ckRec.Checked;/*是否循环发送*/
            var iSpan = GetSpanTime();

            if (opertype == "发送")
            {
                var errInFo = "";

                if (!string.IsNullOrWhiteSpace(errInFo = CheckSendInFo()))
                {
                    MessageBox.Show(errInFo, "提示", MessageBoxButtons.OK);
                    return;
                }

                var framData = new FramData
                {
                    #region
                    FrameType = "DataDown",
                    DevEUI = tbxDev.Text.Trim(),
                    Port = int.Parse(tbxDProt.Text.Trim()),
                    AckRequest = cbReq.Checked,
                    Ack = cbAck.Checked,
                    Data = tbxData.Text.Trim()
                    #endregion
                };

                var json = JsonHelper.SerializeObject(framData);
                var buffer = Encoding.UTF8.GetBytes(json);
                asyncTCPServer.SendAllClient(buffer);
            }
            else
            {
                btnSend.Text = "发送";
            }
        }



        /// <summary>
        /// 获取间隔时间
        /// </summary>
        /// <returns></returns>
        private int GetSpanTime()
        {
            var ispan = 0;
            var span = (tbxSpan.Text ?? "").Trim();

            if (!string.IsNullOrWhiteSpace(span))
            {
                if (!int.TryParse(span, out ispan))
                {
                    ispan = 0;
                }
            }

            return ispan > 0 ? ispan : 0;
        }

        #region[检查发送信息]
        /// <summary>
        /// 检查发生消息
        /// </summary>
        /// <returns>错误信息</returns>
        private string CheckSendInFo()
        {
            var errInFo = CheckDevEUI();
            errInFo = string.IsNullOrWhiteSpace(errInFo) ? CheckPort() : errInFo;
            errInFo = string.IsNullOrWhiteSpace(errInFo) ? CheckData() : errInFo;

            return errInFo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string CheckDevEUI()
        {
            var errInFo = "";

            var devEUI = tbxDev.Text ?? "";

            if (devEUI.Length != 16)
            {
                errInFo = "DevEUI长度必须为16位!";
            }
            else if (!IsHexadecimal(devEUI))
            {
                errInFo = "DevEUI必须为16进制数据!";
            }

            return errInFo;
        }

        private string CheckPort()
        {
            var errInFo = "";

            var port = tbxDProt.Text ?? "";

            if (string.IsNullOrWhiteSpace(port))
            {
                errInFo = "请输入Port数值!";
            }
            else
            {
                int p = 0;

                if (!int.TryParse(tbxDProt.Text.Trim(), out p))
                {
                    errInFo = "Port必须为整数!";
                }
                else if (p < 1 || p > 223)
                {
                    errInFo = "Port范围1～223！";
                }
            }

            return errInFo;
        }

        private string CheckData()
        {
            var errInFo = "";
            var data = (tbxData.Text ?? "").Trim();

            if (!string.IsNullOrWhiteSpace(data))
            {
                if (!IsHexadecimal(data))
                {
                    errInFo = "Data必须为16进制数据!";
                }
                else if (data.Length > 2 * 256)
                {
                    errInFo = "Data长度不能超过512!";
                }
            }

            return errInFo;
        }
        #endregion

        /// <summary>
        /// 判断是否十六进制格式字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsHexadecimal(string str)
        {
            const string PATTERN = @"[A-Fa-f0-9]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(str, PATTERN);
        }

        #region[服务端接收数据]
        private void AsyncTCPServer_DataReceived(object sender, AsyncEventArgs e)
        {
            //e.msg
        }
        #endregion
    }
}
