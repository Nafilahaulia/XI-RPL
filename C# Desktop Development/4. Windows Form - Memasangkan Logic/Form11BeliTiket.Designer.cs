namespace ContohSoal1
{
    partial class Form11BeliTiket
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.useBtn = new System.Windows.Forms.Button();
            this.departureLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.promoText = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.passengerLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.maskapaiLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpPassenger = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(76, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Detail Penumpang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label4.Location = new System.Drawing.Point(78, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(438, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mohon lengkapi seluruh data penumpang di bawah ini dengan benar";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::ContohSoal1.Properties.Resources.chevron_arrow_left;
            this.pictureBox7.Location = new System.Drawing.Point(28, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 36);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // flpPassenger
            // 
            this.flpPassenger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpPassenger.AutoScroll = true;
            this.flpPassenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.flpPassenger.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPassenger.Location = new System.Drawing.Point(28, 100);
            this.flpPassenger.Name = "flpPassenger";
            this.flpPassenger.Size = new System.Drawing.Size(745, 580);
            this.flpPassenger.TabIndex = 14;
            this.flpPassenger.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.departureLabel);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.destinationLabel);
            this.panel1.Controls.Add(this.maskapaiLabel);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.passengerLabel);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.promoText);
            this.panel1.Controls.Add(this.useBtn);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.payBtn);
            this.panel1.Location = new System.Drawing.Point(795, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 580);
            this.panel1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(24, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Penerbangan";
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.departureLabel.Location = new System.Drawing.Point(24, 52);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(171, 21);
            this.departureLabel.TabIndex = 1;
            this.departureLabel.Text = "Soekarno-Hatta (CGK)";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ContohSoal1.Properties.Resources.arrow_right1;
            this.pictureBox4.Location = new System.Drawing.Point(204, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.destinationLabel.Location = new System.Drawing.Point(230, 52);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(111, 21);
            this.destinationLabel.TabIndex = 3;
            this.destinationLabel.Text = "Juanda (SUB)";
            // 
            // maskapaiLabel
            // 
            this.maskapaiLabel.AutoSize = true;
            this.maskapaiLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskapaiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.maskapaiLabel.Location = new System.Drawing.Point(24, 78);
            this.maskapaiLabel.Name = "maskapaiLabel";
            this.maskapaiLabel.Size = new System.Drawing.Size(119, 20);
            this.maskapaiLabel.TabIndex = 4;
            this.maskapaiLabel.Text = "Pelita Air Service";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label21.Location = new System.Drawing.Point(24, 122);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(185, 25);
            this.label21.TabIndex = 5;
            this.label21.Text = "Detail Penerbangan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ContohSoal1.Properties.Resources.calendar_date_mark_circle;
            this.pictureBox2.Location = new System.Drawing.Point(24, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.dateLabel.Location = new System.Drawing.Point(52, 155);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(161, 21);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Monday, 22 May 2023";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContohSoal1.Properties.Resources.time_clock_circle;
            this.pictureBox1.Location = new System.Drawing.Point(24, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.timeLabel.Location = new System.Drawing.Point(52, 189);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 21);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "19:50 - 21:25";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ContohSoal1.Properties.Resources.multiple_man_woman;
            this.pictureBox3.Location = new System.Drawing.Point(24, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // passengerLabel
            // 
            this.passengerLabel.AutoSize = true;
            this.passengerLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.passengerLabel.Location = new System.Drawing.Point(52, 223);
            this.passengerLabel.Name = "passengerLabel";
            this.passengerLabel.Size = new System.Drawing.Size(106, 21);
            this.passengerLabel.TabIndex = 11;
            this.passengerLabel.Text = "5 penumpang";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label20.Location = new System.Drawing.Point(24, 275);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 25);
            this.label20.TabIndex = 12;
            this.label20.Text = "Kode Promo";
            // 
            // promoText
            // 
            this.promoText.BackColor = System.Drawing.Color.White;
            this.promoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.promoText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.promoText.Location = new System.Drawing.Point(24, 305);
            this.promoText.Name = "promoText";
            this.promoText.Size = new System.Drawing.Size(275, 30);
            this.promoText.TabIndex = 13;
            // 
            // useBtn
            // 
            this.useBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.useBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.useBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.useBtn.FlatAppearance.BorderSize = 1;
            this.useBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useBtn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.useBtn.Location = new System.Drawing.Point(310, 303);
            this.useBtn.Name = "useBtn";
            this.useBtn.Size = new System.Drawing.Size(125, 34);
            this.useBtn.TabIndex = 14;
            this.useBtn.Text = "Pakai";
            this.useBtn.UseVisualStyleBackColor = false;
            this.useBtn.Click += new System.EventHandler(this.useBtn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label18.Location = new System.Drawing.Point(24, 435);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 23);
            this.label18.TabIndex = 15;
            this.label18.Text = "Total Pembayaran";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.priceLabel.Location = new System.Drawing.Point(22, 462);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(236, 41);
            this.priceLabel.TabIndex = 16;
            this.priceLabel.Text = "IDR XX.XXX.XXX";
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.payBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payBtn.FlatAppearance.BorderSize = 0;
            this.payBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(24, 515);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(411, 46);
            this.payBtn.TabIndex = 17;
            this.payBtn.Text = "Konfirmasi Pembayaran";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // Form11BeliTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1285, 710);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flpPassenger);
            this.Controls.Add(this.panel1);
            this.Name = "Form11BeliTiket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Detail & Pembayaran Tiket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form11BeliTiket_FormClosing);
            this.Load += new System.EventHandler(this.Form11BeliTiket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button useBtn;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox promoText;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label passengerLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label maskapaiLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpPassenger;
    }
}