namespace WaterMeterSync
{
    partial class Frm_Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Config));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Server_ip = new System.Windows.Forms.TextBox();
            this.Serv_port = new System.Windows.Forms.TextBox();
            this.GP1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Log_url = new System.Windows.Forms.TextBox();
            this.Ref_time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Data_Pass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Data_User = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Data_Instance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Data_Port = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Data_IP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GP1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "监听端口";
            // 
            // Server_ip
            // 
            this.Server_ip.Location = new System.Drawing.Point(91, 20);
            this.Server_ip.Name = "Server_ip";
            this.Server_ip.Size = new System.Drawing.Size(150, 21);
            this.Server_ip.TabIndex = 2;
            // 
            // Serv_port
            // 
            this.Serv_port.Location = new System.Drawing.Point(91, 59);
            this.Serv_port.Name = "Serv_port";
            this.Serv_port.Size = new System.Drawing.Size(56, 21);
            this.Serv_port.TabIndex = 3;
            // 
            // GP1
            // 
            this.GP1.Controls.Add(this.Server_ip);
            this.GP1.Controls.Add(this.Serv_port);
            this.GP1.Controls.Add(this.label2);
            this.GP1.Controls.Add(this.label1);
            this.GP1.Location = new System.Drawing.Point(12, 12);
            this.GP1.Name = "GP1";
            this.GP1.Size = new System.Drawing.Size(270, 99);
            this.GP1.TabIndex = 4;
            this.GP1.TabStop = false;
            this.GP1.Text = "监听设置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Log_url);
            this.groupBox1.Controls.Add(this.Ref_time);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(288, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "日志和刷新";
            // 
            // Log_url
            // 
            this.Log_url.Location = new System.Drawing.Point(108, 20);
            this.Log_url.Name = "Log_url";
            this.Log_url.Size = new System.Drawing.Size(150, 21);
            this.Log_url.TabIndex = 6;
            // 
            // Ref_time
            // 
            this.Ref_time.Location = new System.Drawing.Point(108, 59);
            this.Ref_time.Name = "Ref_time";
            this.Ref_time.Size = new System.Drawing.Size(61, 21);
            this.Ref_time.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "刷新时间(毫秒)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "日志地址";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.Data_Pass);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Data_User);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Data_Instance);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Data_Port);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Data_IP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 123);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据库设置";
            // 
            // Data_Pass
            // 
            this.Data_Pass.Location = new System.Drawing.Point(306, 65);
            this.Data_Pass.Name = "Data_Pass";
            this.Data_Pass.PasswordChar = '*';
            this.Data_Pass.Size = new System.Drawing.Size(150, 21);
            this.Data_Pass.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "密码";
            // 
            // Data_User
            // 
            this.Data_User.Location = new System.Drawing.Point(90, 65);
            this.Data_User.Name = "Data_User";
            this.Data_User.Size = new System.Drawing.Size(150, 21);
            this.Data_User.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "用户名";
            // 
            // Data_Instance
            // 
            this.Data_Instance.Location = new System.Drawing.Point(462, 29);
            this.Data_Instance.Name = "Data_Instance";
            this.Data_Instance.Size = new System.Drawing.Size(56, 21);
            this.Data_Instance.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "实例名称";
            // 
            // Data_Port
            // 
            this.Data_Port.Location = new System.Drawing.Point(321, 29);
            this.Data_Port.Name = "Data_Port";
            this.Data_Port.Size = new System.Drawing.Size(56, 21);
            this.Data_Port.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "监听端口";
            // 
            // Data_IP
            // 
            this.Data_IP.Location = new System.Drawing.Point(90, 29);
            this.Data_IP.Name = "Data_IP";
            this.Data_IP.Size = new System.Drawing.Size(150, 21);
            this.Data_IP.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "数据库地址";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "测试连接";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 410);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Config";
            this.Text = "系统设置";
            this.Load += new System.EventHandler(this.Frm_Config_Load);
            this.GP1.ResumeLayout(false);
            this.GP1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Server_ip;
        private System.Windows.Forms.TextBox Serv_port;
        private System.Windows.Forms.GroupBox GP1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Log_url;
        private System.Windows.Forms.TextBox Ref_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Data_Instance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Data_Port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Data_IP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Data_Pass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Data_User;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}