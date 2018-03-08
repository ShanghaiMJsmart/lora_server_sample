namespace LoraServerSample
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnConect = new System.Windows.Forms.Button();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxSpan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckRec = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbReq = new System.Windows.Forms.CheckBox();
            this.tbxDProt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckStart = new System.Windows.Forms.CheckBox();
            this.tbxFApp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxFDev = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFrame = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtBengin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.SRTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevEUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppEUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AckRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbAck = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.btnConect);
            this.groupBox1.Controls.Add(this.tbxPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxIp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1978, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备连接参数设置";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(958, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 30);
            this.label12.TabIndex = 6;
            this.label12.Text = "类型:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "服务端",
            "客户端"});
            this.cmbType.Location = new System.Drawing.Point(1052, 48);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(217, 38);
            this.cmbType.TabIndex = 5;
            // 
            // btnConect
            // 
            this.btnConect.Location = new System.Drawing.Point(1754, 32);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(187, 54);
            this.btnConect.TabIndex = 4;
            this.btnConect.Text = "连接";
            this.btnConect.UseVisualStyleBackColor = true;
            this.btnConect.Click += new System.EventHandler(this.btnConect_Click);
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(697, 49);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(147, 42);
            this.tbxPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "服务器端口:";
            // 
            // tbxIp
            // 
            this.tbxIp.Location = new System.Drawing.Point(191, 49);
            this.tbxIp.Name = "tbxIp";
            this.tbxIp.Size = new System.Drawing.Size(276, 42);
            this.tbxIp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器ip:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAck);
            this.groupBox2.Controls.Add(this.tbxSpan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ckRec);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.tbxData);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbReq);
            this.groupBox2.Controls.Add(this.tbxDProt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxDev);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1978, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送数据填充";
            // 
            // tbxSpan
            // 
            this.tbxSpan.Location = new System.Drawing.Point(1820, 43);
            this.tbxSpan.Name = "tbxSpan";
            this.tbxSpan.Size = new System.Drawing.Size(147, 42);
            this.tbxSpan.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1431, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(388, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "周期发送时间设定(单位秒):";
            // 
            // ckRec
            // 
            this.ckRec.AutoSize = true;
            this.ckRec.Location = new System.Drawing.Point(1235, 49);
            this.ckRec.Name = "ckRec";
            this.ckRec.Size = new System.Drawing.Size(171, 34);
            this.ckRec.TabIndex = 13;
            this.ckRec.Text = "周期发送";
            this.ckRec.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1780, 207);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(187, 54);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxData
            // 
            this.tbxData.Location = new System.Drawing.Point(191, 105);
            this.tbxData.MaxLength = 256;
            this.tbxData.Multiline = true;
            this.tbxData.Name = "tbxData";
            this.tbxData.Size = new System.Drawing.Size(1776, 96);
            this.tbxData.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data:";
            // 
            // cbReq
            // 
            this.cbReq.AutoSize = true;
            this.cbReq.Location = new System.Drawing.Point(887, 50);
            this.cbReq.Name = "cbReq";
            this.cbReq.Size = new System.Drawing.Size(216, 34);
            this.cbReq.TabIndex = 6;
            this.cbReq.Text = " AckRequest";
            this.cbReq.UseVisualStyleBackColor = true;
            // 
            // tbxDProt
            // 
            this.tbxDProt.Location = new System.Drawing.Point(592, 46);
            this.tbxDProt.Name = "tbxDProt";
            this.tbxDProt.Size = new System.Drawing.Size(276, 42);
            this.tbxDProt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port:";
            // 
            // tbxDev
            // 
            this.tbxDev.Location = new System.Drawing.Point(191, 47);
            this.tbxDev.Name = "tbxDev";
            this.tbxDev.Size = new System.Drawing.Size(276, 42);
            this.tbxDev.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "DevEUI:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckStart);
            this.groupBox3.Controls.Add(this.tbxFApp);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbxFDev);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbFrame);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dtEnd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dtBengin);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 438);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1978, 106);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "展示区报文过滤设置";
            // 
            // ckStart
            // 
            this.ckStart.AutoSize = true;
            this.ckStart.Location = new System.Drawing.Point(1750, 48);
            this.ckStart.Name = "ckStart";
            this.ckStart.Size = new System.Drawing.Size(186, 34);
            this.ckStart.TabIndex = 11;
            this.ckStart.Text = "是/否过滤";
            this.ckStart.UseVisualStyleBackColor = true;
            // 
            // tbxFApp
            // 
            this.tbxFApp.Location = new System.Drawing.Point(1542, 45);
            this.tbxFApp.Name = "tbxFApp";
            this.tbxFApp.Size = new System.Drawing.Size(194, 42);
            this.tbxFApp.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1430, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 30);
            this.label11.TabIndex = 9;
            this.label11.Text = "AppEUI:";
            // 
            // tbxFDev
            // 
            this.tbxFDev.Location = new System.Drawing.Point(1221, 43);
            this.tbxFDev.Name = "tbxFDev";
            this.tbxFDev.Size = new System.Drawing.Size(194, 42);
            this.tbxFDev.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1109, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 30);
            this.label10.TabIndex = 7;
            this.label10.Text = "DevEUI:";
            // 
            // cbFrame
            // 
            this.cbFrame.FormattingEnabled = true;
            this.cbFrame.Location = new System.Drawing.Point(858, 44);
            this.cbFrame.Name = "cbFrame";
            this.cbFrame.Size = new System.Drawing.Size(237, 38);
            this.cbFrame.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(702, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 30);
            this.label9.TabIndex = 5;
            this.label9.Text = "FrameType:";
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtEnd.Location = new System.Drawing.Point(449, 43);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(244, 42);
            this.dtEnd.TabIndex = 4;
            this.dtEnd.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "~";
            // 
            // dtBengin
            // 
            this.dtBengin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtBengin.Location = new System.Drawing.Point(162, 41);
            this.dtBengin.Name = "dtBengin";
            this.dtBengin.Size = new System.Drawing.Size(244, 42);
            this.dtBengin.TabIndex = 2;
            this.dtBengin.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "时间范围:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gridData);
            this.groupBox4.Location = new System.Drawing.Point(12, 550);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1978, 550);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "收发报文展示";
            // 
            // gridData
            // 
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SRTime,
            this.FrameType,
            this.Data,
            this.DevEUI,
            this.AppEUI,
            this.Port,
            this.AckRequest,
            this.Ack});
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(3, 38);
            this.gridData.Name = "gridData";
            this.gridData.RowTemplate.Height = 44;
            this.gridData.Size = new System.Drawing.Size(1972, 509);
            this.gridData.TabIndex = 0;
            this.gridData.VirtualMode = true;
            // 
            // SRTime
            // 
            this.SRTime.HeaderText = "收发时间";
            this.SRTime.Name = "SRTime";
            this.SRTime.ReadOnly = true;
            // 
            // FrameType
            // 
            this.FrameType.HeaderText = "FrameType";
            this.FrameType.Name = "FrameType";
            this.FrameType.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // DevEUI
            // 
            this.DevEUI.HeaderText = "DevEUI";
            this.DevEUI.Name = "DevEUI";
            this.DevEUI.ReadOnly = true;
            // 
            // AppEUI
            // 
            this.AppEUI.HeaderText = "AppEUI";
            this.AppEUI.Name = "AppEUI";
            this.AppEUI.ReadOnly = true;
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            // 
            // AckRequest
            // 
            this.AckRequest.HeaderText = "AckRequest";
            this.AckRequest.Name = "AckRequest";
            this.AckRequest.ReadOnly = true;
            // 
            // Ack
            // 
            this.Ack.HeaderText = "Ack";
            this.Ack.Name = "Ack";
            this.Ack.ReadOnly = true;
            // 
            // cbAck
            // 
            this.cbAck.AutoSize = true;
            this.cbAck.Location = new System.Drawing.Point(1111, 50);
            this.cbAck.Name = "cbAck";
            this.cbAck.Size = new System.Drawing.Size(111, 34);
            this.cbAck.TabIndex = 16;
            this.cbAck.Text = " Ack";
            this.cbAck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2003, 1112);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "控制台";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIp;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDev;
        private System.Windows.Forms.TextBox tbxDProt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbReq;
        private System.Windows.Forms.TextBox tbxData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DateTimePicker dtBengin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFrame;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxFDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevEUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppEUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn AckRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ack;
        private System.Windows.Forms.TextBox tbxFApp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxSpan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckRec;
        private System.Windows.Forms.CheckBox ckStart;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbAck;
    }
}

