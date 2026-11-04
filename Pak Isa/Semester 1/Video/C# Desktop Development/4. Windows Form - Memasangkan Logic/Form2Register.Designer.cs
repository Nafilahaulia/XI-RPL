namespace ContohSoal1
{
    partial class Form2Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lahirDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.daftarBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.brandPanel.Size = new System.Drawing.Size(320, 620);
            this.brandPanel.TabIndex = 10;
            // 
            // brandLogo
            // 
            this.brandLogo.Image = global::ContohSoal1.Properties.Resources.WhatsApp_Image_2026_08_26_at_08_54_22_removebg_preview;
            this.brandLogo.Location = new System.Drawing.Point(54, 165);
            this.brandLogo.Name = "brandLogo";
            this.brandLogo.Size = new System.Drawing.Size(211, 110);
            this.brandLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brandLogo.TabIndex = 0;
            this.brandLogo.TabStop = false;
            // 
            // titleBrand
            // 
            this.titleBrand.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.titleBrand.Location = new System.Drawing.Point(10, 275);
            this.titleBrand.Name = "titleBrand";
            this.titleBrand.Size = new System.Drawing.Size(300, 42);
            this.titleBrand.TabIndex = 1;
            this.titleBrand.Text = "Bromo Airlines";
            this.titleBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtitleBrand
            // 
            this.subtitleBrand.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.subtitleBrand.Location = new System.Drawing.Point(25, 330);
            this.subtitleBrand.Name = "subtitleBrand";
            this.subtitleBrand.Size = new System.Drawing.Size(270, 75);
            this.subtitleBrand.TabIndex = 2;
            this.subtitleBrand.Text = "Daftarkan akun Anda dan nikmati berbagai promo tiket penerbangan terbaik dengan h" +
    "arga bersahabat.";
            this.subtitleBrand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(365, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Akun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(368, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Daftarkan diri Anda untuk mulai memesan tiket pesawat.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(368, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.White;
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.usernameTxt.Location = new System.Drawing.Point(372, 145);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(460, 25);
            this.usernameTxt.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(368, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama Lengkap";
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.White;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.nameTxt.Location = new System.Drawing.Point(372, 215);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(460, 25);
            this.nameTxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(368, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nomor Telepon";
            // 
            // phoneTxt
            // 
            this.phoneTxt.BackColor = System.Drawing.Color.White;
            this.phoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.phoneTxt.Location = new System.Drawing.Point(372, 285);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(460, 25);
            this.phoneTxt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(368, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tanggal Lahir";
            // 
            // lahirDate
            // 
            this.lahirDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lahirDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lahirDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lahirDate.Location = new System.Drawing.Point(372, 355);
            this.lahirDate.Name = "lahirDate";
            this.lahirDate.Size = new System.Drawing.Size(460, 25);
            this.lahirDate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(368, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.White;
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.passwordTxt.Location = new System.Drawing.Point(372, 425);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '●';
            this.passwordTxt.Size = new System.Drawing.Size(460, 25);
            this.passwordTxt.TabIndex = 4;
            // 
            // daftarBtn
            // 
            this.daftarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.daftarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daftarBtn.FlatAppearance.BorderSize = 0;
            this.daftarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.daftarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daftarBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daftarBtn.ForeColor = System.Drawing.Color.White;
            this.daftarBtn.Location = new System.Drawing.Point(372, 480);
            this.daftarBtn.Name = "daftarBtn";
            this.daftarBtn.Size = new System.Drawing.Size(460, 42);
            this.daftarBtn.TabIndex = 5;
            this.daftarBtn.Text = "DAFTAR SEKARANG";
            this.daftarBtn.UseVisualStyleBackColor = false;
            this.daftarBtn.Click += new System.EventHandler(this.daftarBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label8.Location = new System.Drawing.Point(440, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sudah punya akun?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.label9.Location = new System.Drawing.Point(588, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Masuk di sini";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form2Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(890, 620);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.daftarBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lahirDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brandPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Pendaftaran Akun";
            this.brandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brandLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Button daftarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker lahirDate;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel brandPanel;
        private System.Windows.Forms.PictureBox brandLogo;
        private System.Windows.Forms.Label titleBrand;
        private System.Windows.Forms.Label subtitleBrand;
    }
}
