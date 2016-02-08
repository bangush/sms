namespace SMSapplication
{
    partial class SetupDeviceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbThietBi = new System.Windows.Forms.Label();
            this.cbMangDiDong = new System.Windows.Forms.ComboBox();
            this.cbDoTre = new System.Windows.Forms.ComboBox();
            this.cbGioiHan = new System.Windows.Forms.ComboBox();
            this.btnLuuCaiDat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thiết bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mạng di động";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Độ trễ (giây)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới hạn tin nhăn";
            // 
            // lbThietBi
            // 
            this.lbThietBi.AutoSize = true;
            this.lbThietBi.Location = new System.Drawing.Point(112, 42);
            this.lbThietBi.Name = "lbThietBi";
            this.lbThietBi.Size = new System.Drawing.Size(31, 13);
            this.lbThietBi.TabIndex = 1;
            this.lbThietBi.Text = "COM";
            // 
            // cbMangDiDong
            // 
            this.cbMangDiDong.FormattingEnabled = true;
            this.cbMangDiDong.Location = new System.Drawing.Point(110, 73);
            this.cbMangDiDong.Name = "cbMangDiDong";
            this.cbMangDiDong.Size = new System.Drawing.Size(121, 21);
            this.cbMangDiDong.TabIndex = 2;
            // 
            // cbDoTre
            // 
            this.cbDoTre.FormattingEnabled = true;
            this.cbDoTre.Location = new System.Drawing.Point(110, 105);
            this.cbDoTre.Name = "cbDoTre";
            this.cbDoTre.Size = new System.Drawing.Size(121, 21);
            this.cbDoTre.TabIndex = 2;
            // 
            // cbGioiHan
            // 
            this.cbGioiHan.FormattingEnabled = true;
            this.cbGioiHan.Location = new System.Drawing.Point(110, 138);
            this.cbGioiHan.Name = "cbGioiHan";
            this.cbGioiHan.Size = new System.Drawing.Size(121, 21);
            this.cbGioiHan.TabIndex = 2;
            // 
            // btnLuuCaiDat
            // 
            this.btnLuuCaiDat.Location = new System.Drawing.Point(110, 178);
            this.btnLuuCaiDat.Name = "btnLuuCaiDat";
            this.btnLuuCaiDat.Size = new System.Drawing.Size(75, 23);
            this.btnLuuCaiDat.TabIndex = 3;
            this.btnLuuCaiDat.Text = "Lưu cài đặt";
            this.btnLuuCaiDat.UseVisualStyleBackColor = true;
            this.btnLuuCaiDat.Click += new System.EventHandler(this.btnLuuCaiDat_Click);
            // 
            // SetupDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 212);
            this.Controls.Add(this.btnLuuCaiDat);
            this.Controls.Add(this.cbGioiHan);
            this.Controls.Add(this.cbDoTre);
            this.Controls.Add(this.cbMangDiDong);
            this.Controls.Add(this.lbThietBi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetupDeviceForm";
            this.Text = "SetupDevice";
            this.Load += new System.EventHandler(this.SetupDevice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbThietBi;
        public System.Windows.Forms.ComboBox cbMangDiDong;
        public System.Windows.Forms.ComboBox cbDoTre;
        public System.Windows.Forms.ComboBox cbGioiHan;
        private System.Windows.Forms.Button btnLuuCaiDat;
    }
}