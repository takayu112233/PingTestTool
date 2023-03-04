using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PingTestTool
{
    public partial class Main : Form_common
    {
        /*
        void Receive(string message, string topic)
        内のプログラムを変更すると
        様々なmqttメッセージに対応
        */
        readonly bool auto_connect;

        string[] arr_address;
        string[,] arr_board_show_string = new string[100, 100];

        bool scan = false;

        int fontsize = 30;

        int ping_ip_count = 0;
        int last_count = 0;

        System.Net.NetworkInformation.Ping ping = null;

        public Main(bool auto_connect,int fontsize)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            this.auto_connect = auto_connect;
            this.fontsize = fontsize;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            trackBar_font.Maximum = 10;
            trackBar_font.Maximum = 50;

            button_end.Enabled = false;

            this.MinimumSize = this.Size;
            this.WindowState = FormWindowState.Maximized;


            dataGridView_info.ColumnCount = 4;
            dataGridView_info.RowHeadersVisible = false;
            dataGridView_info.ColumnHeadersVisible = false;
            dataGridView_info.ReadOnly = true;

            dataGridView_info.CurrentCell = null;

            dataGridView_info.DefaultCellStyle.Font = new Font("Tahoma", fontsize);
            dataGridView_info.DefaultCellStyle.ForeColor = Color.Gray;
            dataGridView_info.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_info.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView_info.AllowUserToResizeColumns = false;
            dataGridView_info.AllowUserToResizeRows = false;
            dataGridView_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView_info.AllowUserToAddRows = false;
            dataGridView_info.CellBorderStyle = DataGridViewCellBorderStyle.None;


            dataGridView_info.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView_info.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView_info.RowTemplate.DefaultCellStyle.Padding = new Padding(10, 10, 10, 10);



            textBox_logmsg.ScrollBars = ScrollBars.Vertical;
            trackBar_font.Value = fontsize;

            Board_road();

            if (auto_connect)
            {
                button_start.PerformClick();
            }
        }

        private void DataGridView_info_SelectionChanged(object sender, EventArgs e)
        {
            /* データグリッドビューを常に未選択にする為の処理 */
            dataGridView_info.CurrentCell = null;
        }
        public void Cell_cancel_bold(int count)
        {
            /* 標準時のフォントに変更 */
            int y = count / 4;
            int x = count % 4;
            this.dataGridView_info.Rows[y].Cells[x].Style.Font = new Font("Tahoma", fontsize);

        }
        public void Cell_set_bold(int count)
        {
            /* 太字のフォントに変更 */
            int y = count / 4;
            int x = count % 4;
            this.dataGridView_info.Rows[y].Cells[x].Style.Font = new Font("Tahoma", fontsize, FontStyle.Bold);

        }
        public void Cell_set_green(int count)
        {
            /* セルを緑色に変更 */
            int y = count / 4;
            int x = count % 4;
            this.dataGridView_info.Rows[y].Cells[x].Style.BackColor = ColorTranslator.FromHtml("#80FF80");
            this.dataGridView_info.Rows[y].Cells[x].Style.ForeColor = Color.Black;
        }
        public void Cell_set_red(int count)
        {
            /* セルを赤色に変更 */
            int y = count / 4;
            int x = count % 4;
            this.dataGridView_info.Rows[y].Cells[x].Style.BackColor = ColorTranslator.FromHtml("#FF8080");
            this.dataGridView_info.Rows[y].Cells[x].Style.ForeColor = Color.Black;
        }
        public void Cell_set_orange(int count)
        {
            /* セルをオレンジに変更 */
            int y = count / 4;
            int x = count % 4;
            this.dataGridView_info.Rows[y].Cells[x].Style.BackColor = ColorTranslator.FromHtml("#FFFF80");
            this.dataGridView_info.Rows[y].Cells[x].Style.ForeColor = Color.Black;
        }
        public void Cell_set_default_color(int count)
        {
            /* セルの */
            int y = count / 4;
            int x = count % 4;
            this.dataGridView_info.Rows[y].Cells[x].Style.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dataGridView_info.Rows[y].Cells[x].Style.ForeColor = Color.Gray;
        }
        public void Cell_set_default(int count)
        {
            /* セルをデフォルトの色とフォントに変更 */
            int y = count / 4;
            int x = count % 4;
            this.dataGridView_info.Rows[y].Cells[x].Style.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.dataGridView_info.Rows[y].Cells[x].Style.ForeColor = Color.Gray;
            this.dataGridView_info.Rows[y].Cells[x].Style.Font = new Font("Tahoma", fontsize);
        }
        public void Cell_set_text(int count, string address, string time, string ttl)
        {
            /* セル内テキストの変更 */
            int y = count / 4;
            int x = count % 4;
            this.dataGridView_info.Rows[y].Cells[x].Value = address + "\n" + time + "ms" + " ttl:" + ttl;
        }
        public void All_reset()
        {
            /* リセット */
            for (int count = 0; count < arr_address.Length; count++)
            {
                Cell_set_default(count); 
                Cell_set_text(count, arr_address[count], "--", "--");
            }
        }

        private void Button_reset_Click(object sender, EventArgs e)
        {
            /* リセットボタン押下時の動作 */
            All_reset();
        }

        private void Button_setting_Click(object sender, EventArgs e)
        {
            /* 設定 */
            WriteLog("設定開始");
            Setting setting = new Setting();
            setting.ShowDialog();
            if(setting.save == 1)
            {
                WriteLog("設定完了");
                Board_road();
            }
            else
            {
                WriteLog("設定キャンセル");
            }
            setting.Dispose();
        }

        private void Board_road()
        {
            /* アドレス情報の読込 */
            dataGridView_info.Rows.Clear();

            arr_board_show_string = new string[100, 100];

            StreamReader sr = new StreamReader(@"address.csv");
            string s1 = sr.ReadToEnd();
            sr.Close();
            s1 = s1.Replace(Environment.NewLine, "\n");
            s1 = s1.Trim('\n');
            arr_address = s1.Split('\n');

            int count4 = 0;
            int line = 0;
            for (int insertcount = 0; insertcount < arr_address.Length; insertcount++)
            {
                arr_board_show_string[line, count4] = "";

                count4++;
                if (count4 == 4)
                {
                    count4 = 0;
                    line++;
                }
            }

            for (int count = 0; count < arr_board_show_string.GetLength(0); count += 1)
            {
                if (arr_board_show_string[count, 0] == null) break;
                dataGridView_info.Rows.Add(arr_board_show_string[count, 0], arr_board_show_string[count, 1], arr_board_show_string[count, 2], arr_board_show_string[count, 3]);
            }

            All_reset();
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            scan = true;
            All_reset();
            WriteLog("監視を開始します");
            label_show_info.Text = "監視中";
            button_setting.Enabled = false;
            button_start.Enabled = false;
            button_end.Enabled = true;

            ping_ip_count = 0;
            timer_200.Enabled = true;
        }

        private void Button_end_Click(object sender, EventArgs e)
        {
            scan = false;
            label_show_info.Text = "休止中";
            WriteLog("監視を停止しました");
            button_setting.Enabled = true;
            button_start.Enabled = true;
            button_end.Enabled = false;

            ping_ip_count = 0;
            timer_200.Enabled = false;

            if (ping != null) ping.SendAsyncCancel();
        }

        void WriteLog(String logText)
        {
            /*ログにメッセージを追加(通常)*/
            if (textBox_logmsg.Lines.Length > 500)
            {
                List<string> lines = new List<string>(textBox_logmsg.Lines);
                lines.RemoveAt(0);
                textBox_logmsg.Text = String.Join("\r\n", lines);
            }
            textBox_logmsg.SelectionStart = textBox_logmsg.Text.Length;
            textBox_logmsg.SelectionLength = 0;
            textBox_logmsg.SelectedText = "[" + System.DateTime.Now.ToString() + "] " + logText + "\r\n";

        }
        private void Button_debug_Click(object sender, EventArgs e)
        {
            /* デバッグ用ボタン */
        }


        private void TrackBar_font_Scroll(object sender, EventArgs e)
        {
            /* 表示サイズトラックバー、変更時 */
            fontsize = trackBar_font.Value;
            Size_change(trackBar_font.Value);
            try
            { 
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["FontSize"].Value = trackBar_font.Value.ToString();
                config.Save(); 
            }
            catch (Exception)
            {

            }
        }

        private void Size_change(int size)
        {
            /*ボード状態表示のサイズを変更します*/
            for (int count = 0; count < arr_address.Length; count++)
            {
                this.dataGridView_info.Rows[count / 4].Cells[count % 4].Style.Font = new Font("Tahoma", size);
            }
        }

        private void timer_demo_1000_Tick(object sender, EventArgs e)
        {
            /* 監視デモ用 */
            timer_200.Enabled = false;
            if (ping_ip_count == arr_address.Length) ping_ip_count = 0;
            Cell_cancel_bold(last_count);
            Cell_set_bold(ping_ip_count);
            try
            {
                Cell_set_text(ping_ip_count, arr_address[ping_ip_count], "--", "--");

                if (ping == null)
                {
                    ping = new System.Net.NetworkInformation.Ping();
                    ping.PingCompleted += new System.Net.NetworkInformation.PingCompletedEventHandler(Ping_Completed);
                }

                System.Net.NetworkInformation.PingOptions opts = new System.Net.NetworkInformation.PingOptions(64, true);
                byte[] bs = System.Text.Encoding.ASCII.GetBytes(new string('A', 32));
                ping.SendAsync(arr_address[ping_ip_count], 1000, bs, opts, null);
            }
            catch
            {

            }
            last_count = ping_ip_count;
        }

        private void Ping_Completed(object sender, System.Net.NetworkInformation.PingCompletedEventArgs e)
        {
            if (!scan) return;

            if (e.Error != null)
            {
                Console.WriteLine("エラー:" + e.Error.Message);
            }
            else
            {
                if (e.Reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    //Console.WriteLine("Reply from {0}:bytes={1} time={2}ms TTL={3}",e.Reply.Address, e.Reply.Buffer.Length,e.Reply.RoundtripTime, e.Reply.Options.Ttl);
                    Cell_set_green(ping_ip_count);
                    Cell_set_text(ping_ip_count, arr_address[ping_ip_count], e.Reply.RoundtripTime.ToString(), e.Reply.Options.Ttl.ToString());
                }
                else
                {
                    //Console.WriteLine("err:{0}", e.Reply.Status);
                    Cell_set_text(ping_ip_count, arr_address[ping_ip_count], "--", "--");
                    Cell_set_red(ping_ip_count);
                }
            }
            if (scan) timer_200.Enabled = true;
            ping_ip_count++;
        }
    }
}

