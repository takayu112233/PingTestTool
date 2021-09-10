using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace PingTestTool
{
    public partial class Setting :  Form_common
    {
        public int save = 0;
        public Setting()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            button_ok.Enabled = true;
        }


        private void Button_ip_edit_Click(object sender, EventArgs e)
        {
            bool datacheck = true;
            while (datacheck)
            {
                MessageBox.Show("メモ帳を開きます 改行でアドレスを記載してください", "IPアドレスを編集", MessageBoxButtons.OK, MessageBoxIcon.None);
                System.Diagnostics.Process.Start("notepad.exe", @"address.csv");

                StreamReader sr = new StreamReader(@"address.csv");
                string ip_string = sr.ReadToEnd();
                sr.Close();

                ip_string = ip_string.Replace(Environment.NewLine, "\r");
                ip_string = ip_string.Trim('\r');

                datacheck = false;　
                //チェックの項目は削除
            }
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            save = 1;
            if(save == 1)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["UseConfig"].Value = "1";
                config.Save();
            }
            this.Close();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            save = 0;
            this.Close();
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }
    }
}
