namespace PingTestTool
{
    partial class Setting
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.button_ip_edit = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ping送信先設定";
            // 
            // button_ip_edit
            // 
            this.button_ip_edit.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.button_ip_edit.Location = new System.Drawing.Point(204, 6);
            this.button_ip_edit.Name = "button_ip_edit";
            this.button_ip_edit.Size = new System.Drawing.Size(89, 31);
            this.button_ip_edit.TabIndex = 5;
            this.button_ip_edit.Text = "編集";
            this.button_ip_edit.UseVisualStyleBackColor = true;
            this.button_ip_edit.Click += new System.EventHandler(this.Button_ip_edit_Click);
            // 
            // button_ok
            // 
            this.button_ok.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.button_ok.Location = new System.Drawing.Point(162, 53);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(131, 31);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.Button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.button_cancel.Location = new System.Drawing.Point(16, 53);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(131, 31);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "キャンセル";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 96);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_ip_edit);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Setting";
            this.Text = "PingTestTool";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ip_edit;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
    }
}

