namespace PingTestTool
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_info = new System.Windows.Forms.DataGridView();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_setting = new System.Windows.Forms.Button();
            this.label_show_info = new System.Windows.Forms.Label();
            this.button_end = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_logmsg = new System.Windows.Forms.TextBox();
            this.button_debug = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_font = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label_log = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_200 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_font)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_info
            // 
            this.dataGridView_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_info.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_info.Location = new System.Drawing.Point(13, 61);
            this.dataGridView_info.Name = "dataGridView_info";
            this.dataGridView_info.Size = new System.Drawing.Size(936, 572);
            this.dataGridView_info.TabIndex = 43;
            this.dataGridView_info.SelectionChanged += new System.EventHandler(this.DataGridView_info_SelectionChanged);
            // 
            // button_reset
            // 
            this.button_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_reset.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.button_reset.Location = new System.Drawing.Point(138, 647);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(131, 31);
            this.button_reset.TabIndex = 7;
            this.button_reset.Text = "リセット";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.Button_reset_Click);
            // 
            // button_setting
            // 
            this.button_setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_setting.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.button_setting.Location = new System.Drawing.Point(10, 647);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(122, 31);
            this.button_setting.TabIndex = 8;
            this.button_setting.Text = "設定";
            this.button_setting.UseVisualStyleBackColor = true;
            this.button_setting.Click += new System.EventHandler(this.Button_setting_Click);
            // 
            // label_show_info
            // 
            this.label_show_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_show_info.AutoSize = true;
            this.label_show_info.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label_show_info.Location = new System.Drawing.Point(1160, 9);
            this.label_show_info.Name = "label_show_info";
            this.label_show_info.Size = new System.Drawing.Size(46, 24);
            this.label_show_info.TabIndex = 16;
            this.label_show_info.Text = "---";
            // 
            // button_end
            // 
            this.button_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_end.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.button_end.Location = new System.Drawing.Point(1131, 647);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(122, 31);
            this.button_end.TabIndex = 17;
            this.button_end.Text = "監視終了";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.Button_end_Click);
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.button_start.Location = new System.Drawing.Point(1003, 647);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(122, 31);
            this.button_start.TabIndex = 18;
            this.button_start.Text = "監視開始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // textBox_logmsg
            // 
            this.textBox_logmsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_logmsg.BackColor = System.Drawing.Color.White;
            this.textBox_logmsg.Location = new System.Drawing.Point(955, 61);
            this.textBox_logmsg.Multiline = true;
            this.textBox_logmsg.Name = "textBox_logmsg";
            this.textBox_logmsg.ReadOnly = true;
            this.textBox_logmsg.Size = new System.Drawing.Size(297, 572);
            this.textBox_logmsg.TabIndex = 28;
            // 
            // button_debug
            // 
            this.button_debug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_debug.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.button_debug.Location = new System.Drawing.Point(364, 647);
            this.button_debug.Name = "button_debug";
            this.button_debug.Size = new System.Drawing.Size(131, 31);
            this.button_debug.TabIndex = 29;
            this.button_debug.Text = "デバック用";
            this.button_debug.UseVisualStyleBackColor = true;
            this.button_debug.Visible = false;
            this.button_debug.Click += new System.EventHandler(this.Button_debug_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 666);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "v1.0.0";
            // 
            // trackBar_font
            // 
            this.trackBar_font.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_font.Location = new System.Drawing.Point(650, 647);
            this.trackBar_font.Maximum = 50;
            this.trackBar_font.Minimum = 10;
            this.trackBar_font.Name = "trackBar_font";
            this.trackBar_font.Size = new System.Drawing.Size(270, 45);
            this.trackBar_font.TabIndex = 35;
            this.trackBar_font.Value = 30;
            this.trackBar_font.Scroll += new System.EventHandler(this.TrackBar_font_Scroll);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 666);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "ボード状態表示サイズ";
            // 
            // label_log
            // 
            this.label_log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_log.AutoSize = true;
            this.label_log.Location = new System.Drawing.Point(962, 43);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(23, 12);
            this.label_log.TabIndex = 39;
            this.label_log.Text = "ログ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 41;
            this.label9.Text = "結果";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(1096, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "状態";
            // 
            // timer_200
            // 
            this.timer_200.Interval = 200;
            this.timer_200.Tick += new System.EventHandler(this.timer_demo_1000_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dataGridView_info);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_log);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar_font);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_debug);
            this.Controls.Add(this.textBox_logmsg);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.label_show_info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_setting);
            this.Controls.Add(this.button_reset);
            this.Name = "Main";
            this.Text = "PingTestTool";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_font)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_info;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_setting;
        private System.Windows.Forms.Label label_show_info;
        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textBox_logmsg;
        private System.Windows.Forms.Button button_debug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar_font;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_200;
    }
}