using System;
using System.Windows.Forms;

namespace PingTestTool
{
    public partial class StartMenu : Form_common
    {
        int count = 5;
        public bool start = false;
        public StartMenu()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            timer1000.Enabled = true;
        }

        private void Button_connect_Click(object sender, EventArgs e)
        {
            start = true;
            this.Close();
        }

        private void Timer1000_Tick(object sender, EventArgs e)
        {
            count--;
            label_count.Text = count.ToString();
            if(count == 0)
            {
                start = true;
                this.Close();
            }
        }

        private void Button_setting_Click(object sender, EventArgs e)
        {
            start = false;
            this.Close();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
