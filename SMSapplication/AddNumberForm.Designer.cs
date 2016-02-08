namespace SMSapplication
{
    partial class AddNumberForm
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
            this.rtbNumberAdd = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbNumberAdd
            // 
            this.rtbNumberAdd.Location = new System.Drawing.Point(10, 68);
            this.rtbNumberAdd.Name = "rtbNumberAdd";
            this.rtbNumberAdd.Size = new System.Drawing.Size(262, 181);
            this.rtbNumberAdd.TabIndex = 0;
            this.rtbNumberAdd.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập sđt, cách nhau bởi dấu \";\"";
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(99, 255);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(75, 23);
            this.btnAddNumber.TabIndex = 2;
            this.btnAddNumber.Text = "Thêm số";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // AddNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbNumberAdd);
            this.Name = "AddNumber";
            this.Text = "AddNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbNumberAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNumber;

    }
}