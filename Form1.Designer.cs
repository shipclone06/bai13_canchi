namespace bai13_canchi
{
    partial class Form1
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
            this.btntinh = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.nam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcanchi = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.lstnam = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(221, 77);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(92, 49);
            this.btntinh.TabIndex = 0;
            this.btntinh.Text = "tinh";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(221, 146);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(92, 46);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Location = new System.Drawing.Point(12, 77);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(29, 13);
            this.nam.TabIndex = 1;
            this.nam.Text = "Năm";
            this.nam.Click += new System.EventHandler(this.nam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "căn chi";
            // 
            // txtcanchi
            // 
            this.txtcanchi.Location = new System.Drawing.Point(86, 146);
            this.txtcanchi.Name = "txtcanchi";
            this.txtcanchi.Size = new System.Drawing.Size(100, 20);
            this.txtcanchi.TabIndex = 2;
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(86, 77);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(100, 20);
            this.txtnam.TabIndex = 2;
            // 
            // lstnam
            // 
            this.lstnam.FormattingEnabled = true;
            this.lstnam.Location = new System.Drawing.Point(343, 77);
            this.lstnam.Name = "lstnam";
            this.lstnam.Size = new System.Drawing.Size(122, 160);
            this.lstnam.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstnam);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtcanchi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btntinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label nam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcanchi;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.ListBox lstnam;
    }
}

