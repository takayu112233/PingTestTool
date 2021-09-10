namespace PingTestTool
{
    partial class StartMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.button_setting = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.timer1000 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "PING確認ソフトウェア";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(115, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "秒後、前回の設定で監視します";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_count.Location = new System.Drawing.Point(76, 61);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(44, 48);
            this.label_count.TabIndex = 12;
            this.label_count.Text = "5";
            // 
            // button_setting
            // 
            this.button_setting.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.button_setting.Location = new System.Drawing.Point(12, 121);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(131, 31);
            this.button_setting.TabIndex = 13;
            this.button_setting.Text = "再設定";
            this.button_setting.UseVisualStyleBackColor = true;
            this.button_setting.Click += new System.EventHandler(this.Button_setting_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label3.Location = new System.Drawing.Point(21, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "残り";
            // 
            // button_connect
            // 
            this.button_connect.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.button_connect.Location = new System.Drawing.Point(310, 121);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(131, 31);
            this.button_connect.TabIndex = 15;
            this.button_connect.Text = "監視開始";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // timer1000
            // 
            this.timer1000.Interval = 1000;
            this.timer1000.Tick += new System.EventHandler(this.Timer1000_Tick);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 155);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_setting);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartMenu";
            this.Text = "PingTestTool";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Button button_setting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Timer timer1000;
    }
}