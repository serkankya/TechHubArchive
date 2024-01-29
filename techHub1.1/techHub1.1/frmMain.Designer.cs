namespace techHub1._1
{
    partial class frmMain
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOgrBilgi = new System.Windows.Forms.Button();
            this.btnNotBilgi = new System.Windows.Forms.Button();
            this.btnSafeExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.Location = new System.Drawing.Point(82, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(196, 24);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Hoş geldin, username";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(44, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(272, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "26 Ağustos 2024 Perşembe 24:24:24";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOgrBilgi
            // 
            this.btnOgrBilgi.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOgrBilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgrBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrBilgi.Location = new System.Drawing.Point(12, 72);
            this.btnOgrBilgi.Name = "btnOgrBilgi";
            this.btnOgrBilgi.Size = new System.Drawing.Size(337, 59);
            this.btnOgrBilgi.TabIndex = 2;
            this.btnOgrBilgi.Text = "Öğrenci Bilgi Sistemi";
            this.btnOgrBilgi.UseVisualStyleBackColor = false;
            this.btnOgrBilgi.Click += new System.EventHandler(this.btnOgrBilgi_Click);
            // 
            // btnNotBilgi
            // 
            this.btnNotBilgi.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNotBilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotBilgi.Location = new System.Drawing.Point(12, 141);
            this.btnNotBilgi.Name = "btnNotBilgi";
            this.btnNotBilgi.Size = new System.Drawing.Size(337, 59);
            this.btnNotBilgi.TabIndex = 2;
            this.btnNotBilgi.Text = "Not Görüntüleme Sistemi";
            this.btnNotBilgi.UseVisualStyleBackColor = false;
            this.btnNotBilgi.Click += new System.EventHandler(this.btnNotBilgi_Click);
            // 
            // btnSafeExit
            // 
            this.btnSafeExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnSafeExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSafeExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSafeExit.Location = new System.Drawing.Point(12, 210);
            this.btnSafeExit.Name = "btnSafeExit";
            this.btnSafeExit.Size = new System.Drawing.Size(337, 59);
            this.btnSafeExit.TabIndex = 2;
            this.btnSafeExit.Text = "Güvenli Çıkış";
            this.btnSafeExit.UseVisualStyleBackColor = false;
            this.btnSafeExit.Click += new System.EventHandler(this.btnSafeExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(362, 293);
            this.Controls.Add(this.btnSafeExit);
            this.Controls.Add(this.btnNotBilgi);
            this.Controls.Add(this.btnOgrBilgi);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOgrBilgi;
        private System.Windows.Forms.Button btnNotBilgi;
        private System.Windows.Forms.Button btnSafeExit;
    }
}