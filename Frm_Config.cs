using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace WaterMeterSync
{
    public partial class Frm_Config : Form
    {
        string iniurl = Application.StartupPath + "//sysconfig.ini";
      
        public Frm_Config()
        {
            InitializeComponent();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Config_Load(object sender, EventArgs e)
        {
            


            Server_ip.Text = SetIni.getString("listenr", "serverip", "", iniurl);
            Serv_port.Text = SetIni.getString("listenr", "port", "", iniurl);
            Log_url.Text = SetIni.getString("log", "url", "", iniurl);
            Ref_time.Text = SetIni.getString("log", "ref", "", iniurl);
            Data_IP.Text = SetIni.getString("data", "server", "", iniurl);
            Data_Port.Text = SetIni.getString("data", "port", "", iniurl);
            Data_Instance.Text = SetIni.getString("data", "sid", "", iniurl);
            Data_User.Text = SetIni.getString("data", "user", "", iniurl);
            Data_Pass.Text = SetIni.getString("data", "pass", "", iniurl);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetIni.writeString("listenr", "serverip", Server_ip.Text, iniurl);
            SetIni.writeString("listenr", "port", Serv_port.Text, iniurl);
            SetIni.writeString("log", "url", Log_url.Text, iniurl);
            SetIni.writeString("log", "ref", Ref_time.Text, iniurl);
            SetIni.writeString("data", "server", Data_IP.Text, iniurl);
            SetIni.writeString("data", "port", Data_Port.Text, iniurl);
            SetIni.writeString("data", "sid", Data_Instance.Text, iniurl);
            SetIni.writeString("data", "user", Data_User.Text, iniurl);
            SetIni.writeString("data", "pass", Data_Pass.Text, iniurl);
            MessageBox.Show("保存成功！");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             //=================================================================             
            string connString;  //定义连接数据库的字符串  
            OracleConnection conn = new OracleConnection();//进行连接 
            connString = "User Id=" + Data_User.Text + ";password=" + Data_Pass.Text + ";Data Source=" + Data_IP.Text + ":" + Data_Port.Text + "/" + Data_Instance.Text;
            try
            {
                conn.ConnectionString = connString;
                conn.Open();
                MessageBox.Show("连接成功！");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }

       

        
    }
}
