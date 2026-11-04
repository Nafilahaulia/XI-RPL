namespace ContohSoal1
{
    partial class Form1Login
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
            this.brandPanel = new System.Windows.Forms.Panel();
            this.brandLogo = new System.Windows.Forms.PictureBox();
            this.titleBrand = new System.Windows.Forms.Label();
            this.subtitleBrand = new System.Windows.Forms.Label();
            this.headerLogin = new System.Windows.Forms.Label();
            this.subheaderLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // brandPanel
            // 
            this.brandPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.brandPanel.Controls.Add(this.brandLogo);
            this.brandPanel.Controls.Add(this.titleBrand);
            this.brandPanel.Controls.Add(this.subtitleBrand);
            this.brandPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.brandPanel.Location = new System.Drawing.Point(0, 0);
            this.brandPanel.Name = "brandPanel";
            this.brandPanel.Size = new System.Drawing.Size(350, 500);
            this.brandPanel.TabIndex = 7;
            // 
            // brandLogo
            // 
            this.brandLogo.Image = global::ContohSoal1.Properties.Resources.WhatsApp_Image_2026_08_26_at_08_54_22_removebg_preview;
            this.brandLogo.Location = new System.Drawing.Point(73, 120);
            this.brandLogo.Name = "brandLogo";
            this.brandLogo.Size = new System.Drawing.Size(204, 97);
            this.brandLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brandLogo.TabIndex = 0;
            this.brandLogo.TabStop = false;
            // 
            // titleBrand
            // 
            this.titleBrand.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.titleBrand.Location = new System.Drawing.Point(20, 220);
            this.titleBrand.Name = "titleBrand";
            this.titleBrand.Size = new System.Drawing.Size(310, 42);
            this.titleBrand.TabIndex = 1;
            this.titleBrand.Text = "Bromo Airlines";
            this.titleBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtitleBrand
            // 
            this.subtitleBrand.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.subtitleBrand.Location = new System.Drawing.Point(30, 272);
            this.subtitleBrand.Name = "subtitleBrand";
            this.subtitleBrand.Size = new System.Drawing.Size(290, 60);
            this.subtitleBrand.TabIndex = 2;
            this.subtitleBrand.Text = "Terbang Lebih Nyaman, Cepat & Terpercaya Menuju Destinasi Impian";
            this.subtitleBrand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // headerLogin
            // 
            this.headerLogin.AutoSize = true;
            this.headerLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.headerLogin.Location = new System.Drawing.Point(408, 60);
            this.headerLogin.Name = "headerLogin";
            this.headerLogin.Size = new System.Drawing.Size(156, 32);
            this.headerLogin.TabIndex = 8;
            this.headerLogin.Text = "Masuk Akun";
            // 
            // subheaderLogin
            // 
            this.subheaderLogin.AutoSize = true;
            this.subheaderLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subheaderLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.subheaderLogin.Location = new System.Drawing.Point(410, 105);
            this.subheaderLogin.Name = "subheaderLogin";
            this.subheaderLogin.Size = new System.Drawing.Size(289, 17);
            this.subheaderLogin.TabIndex = 9;
            this.subheaderLogin.Text = "Silakan masukkan detail akun Anda untuk masuk.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(410, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.White;
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.usernameTxt.Location = new System.Drawing.Point(412, 180);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(380, 25);
            this.usernameTxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(410, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.White;
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.passwordTxt.Location = new System.Drawing.Point(412, 250);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '●';
            this.passwordTxt.Size = new System.Drawing.Size(380, 25);
            this.passwordTxt.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(412, 310);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(380, 42);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "MASUK";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label3.Location = new System.Drawing.Point(455, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Belum Punya Akun?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(598, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Daftar Sekarang!";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(860, 500);
            this.Controls.Add(this.headerLogin);
            this.Controls.Add(this.subheaderLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brandPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Masuk";
            this.brandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brandLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel brandPanel;
        private System.Windows.Forms.PictureBox brandLogo;
        private System.Windows.Forms.Label titleBrand;
        private System.Windows.Forms.Label subtitleBrand;
        private System.Windows.Forms.Label headerLogin;
        private System.Windows.Forms.Label subheaderLogin;
    }
}
