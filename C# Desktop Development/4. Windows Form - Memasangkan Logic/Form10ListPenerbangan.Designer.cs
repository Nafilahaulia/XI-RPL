namespace ContohSoal1
{
    partial class Form10ListPenerbangan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.applyBtn = new System.Windows.Forms.Button();
            this.departureLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.passengerLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.timeCheck1 = new System.Windows.Forms.CheckBox();
            this.timeCheck2 = new System.Windows.Forms.CheckBox();
            this.timeCheck3 = new System.Windows.Forms.CheckBox();
            this.timeCheck4 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridPenerbangan = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaPerTiket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeliTiket = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPenerbangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.pictureBox7);
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Controls.Add(this.departureLabel);
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.destinationLabel);
            this.headerPanel.Controls.Add(this.pictureBox2);
            this.headerPanel.Controls.Add(this.dateLabel);
            this.headerPanel.Controls.Add(this.pictureBox3);
            this.headerPanel.Controls.Add(this.passengerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1120, 110);
            this.headerPanel.TabIndex = 15;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::ContohSoal1.Properties.Resources.chevron_arrow_left;
            this.pictureBox7.Location = new System.Drawing.Point(25, 20);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(80, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Daftar Penerbangan Pilihan";
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.departureLabel.Location = new System.Drawing.Point(82, 68);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(176, 21);
            this.departureLabel.TabIndex = 7;
            this.departureLabel.Text = "Soekarno-Hatta (CGK)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContohSoal1.Properties.Resources.arrow_right1;
            this.pictureBox1.Location = new System.Drawing.Point(280, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.destinationLabel.Location = new System.Drawing.Point(315, 68);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(161, 21);
            this.destinationLabel.TabIndex = 7;
            this.destinationLabel.Text = "Juanda Airport (SUB)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ContohSoal1.Properties.Resources.calendar_date_mark_circle;
            this.pictureBox2.Location = new System.Drawing.Point(525, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.dateLabel.Location = new System.Drawing.Point(555, 68);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(165, 21);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Sabtu, 24 Oktober 2026";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ContohSoal1.Properties.Resources.multiple_man_woman;
            this.pictureBox3.Location = new System.Drawing.Point(765, 68);
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
            this.passengerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.passengerLabel.Location = new System.Drawing.Point(795, 68);
            this.passengerLabel.Name = "passengerLabel";
            this.passengerLabel.Size = new System.Drawing.Size(107, 21);
            this.passengerLabel.TabIndex = 7;
            this.passengerLabel.Text = "1 Penumpang";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridPenerbangan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sortBox);
            this.groupBox1.Controls.Add(this.applyBtn);
            this.groupBox1.Controls.Add(this.timeCheck4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.timeCheck3);
            this.groupBox1.Controls.Add(this.timeCheck1);
            this.groupBox1.Controls.Add(this.timeCheck2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(25, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 560);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter & Urutkan Penerbangan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(25, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Waktu Keberangkatan";
            // 
            // timeCheck1
            // 
            this.timeCheck1.AutoSize = true;
            this.timeCheck1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.timeCheck1.Location = new System.Drawing.Point(28, 65);
            this.timeCheck1.Name = "timeCheck1";
            this.timeCheck1.Size = new System.Drawing.Size(117, 24);
            this.timeCheck1.TabIndex = 12;
            this.timeCheck1.Text = "00:00 - 06:00";
            this.timeCheck1.UseVisualStyleBackColor = true;
            // 
            // timeCheck2
            // 
            this.timeCheck2.AutoSize = true;
            this.timeCheck2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.timeCheck2.Location = new System.Drawing.Point(165, 65);
            this.timeCheck2.Name = "timeCheck2";
            this.timeCheck2.Size = new System.Drawing.Size(117, 24);
            this.timeCheck2.TabIndex = 12;
            this.timeCheck2.Text = "06:00 - 12:00";
            this.timeCheck2.UseVisualStyleBackColor = true;
            // 
            // timeCheck3
            // 
            this.timeCheck3.AutoSize = true;
            this.timeCheck3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.timeCheck3.Location = new System.Drawing.Point(305, 65);
            this.timeCheck3.Name = "timeCheck3";
            this.timeCheck3.Size = new System.Drawing.Size(117, 24);
            this.timeCheck3.TabIndex = 12;
            this.timeCheck3.Text = "12:00 - 18:00";
            this.timeCheck3.UseVisualStyleBackColor = true;
            // 
            // timeCheck4
            // 
            this.timeCheck4.AutoSize = true;
            this.timeCheck4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.timeCheck4.Location = new System.Drawing.Point(445, 65);
            this.timeCheck4.Name = "timeCheck4";
            this.timeCheck4.Size = new System.Drawing.Size(117, 24);
            this.timeCheck4.TabIndex = 12;
            this.timeCheck4.Text = "18:00 - 24:00";
            this.timeCheck4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(25, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Urutkan Berdasarkan";
            // 
            // sortBox
            // 
            this.sortBox.BackColor = System.Drawing.Color.White;
            this.sortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortBox.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "Harga terendah",
            "Keberangkatan paling awal",
            "Keberangkatan paling akhir",
            "Kedatangan paling awal",
            "Kedatangan paling akhir",
            "Durasi tercepat"});
            this.sortBox.Location = new System.Drawing.Point(28, 135);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(280, 29);
            this.sortBox.TabIndex = 11;
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.applyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyBtn.FlatAppearance.BorderSize = 0;
            this.applyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.applyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyBtn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.ForeColor = System.Drawing.Color.White;
            this.applyBtn.Location = new System.Drawing.Point(860, 130);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(185, 36);
            this.applyBtn.TabIndex = 9;
            this.applyBtn.Text = "Terapkan Filter";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // dataGridPenerbangan
            // 
            this.dataGridPenerbangan.AllowUserToAddRows = false;
            this.dataGridPenerbangan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPenerbangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPenerbangan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridPenerbangan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPenerbangan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPenerbangan.ColumnHeadersHeight = 36;
            this.dataGridPenerbangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridPenerbangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KodePenerbangan,
            this.Maskapai,
            this.BandaraKeberangkatan,
            this.BandaraTujuan,
            this.HargaPerTiket,
            this.Tanggal,
            this.Jam,
            this.BeliTiket});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPenerbangan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPenerbangan.EnableHeadersVisualStyles = false;
            this.dataGridPenerbangan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridPenerbangan.Location = new System.Drawing.Point(25, 185);
            this.dataGridPenerbangan.Name = "dataGridPenerbangan";
            this.dataGridPenerbangan.RowHeadersVisible = false;
            this.dataGridPenerbangan.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dataGridPenerbangan.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPenerbangan.RowTemplate.Height = 32;
            this.dataGridPenerbangan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPenerbangan.Size = new System.Drawing.Size(1020, 350);
            this.dataGridPenerbangan.TabIndex = 13;
            this.dataGridPenerbangan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPenerbangan_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 60;
            // 
            // KodePenerbangan
            // 
            this.KodePenerbangan.DataPropertyName = "KodePenerbangan";
            this.KodePenerbangan.HeaderText = "Kode";
            this.KodePenerbangan.MinimumWidth = 6;
            this.KodePenerbangan.Name = "KodePenerbangan";
            this.KodePenerbangan.Width = 100;
            // 
            // Maskapai
            // 
            this.Maskapai.DataPropertyName = "Maskapai";
            this.Maskapai.HeaderText = "Maskapai";
            this.Maskapai.MinimumWidth = 6;
            this.Maskapai.Name = "Maskapai";
            this.Maskapai.Width = 140;
            // 
            // BandaraKeberangkatan
            // 
            this.BandaraKeberangkatan.DataPropertyName = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.HeaderText = "Keberangkatan";
            this.BandaraKeberangkatan.MinimumWidth = 6;
            this.BandaraKeberangkatan.Name = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.Width = 145;
            // 
            // BandaraTujuan
            // 
            this.BandaraTujuan.DataPropertyName = "BandaraTujuan";
            this.BandaraTujuan.HeaderText = "Tujuan";
            this.BandaraTujuan.MinimumWidth = 6;
            this.BandaraTujuan.Name = "BandaraTujuan";
            this.BandaraTujuan.Width = 145;
            // 
            // HargaPerTiket
            // 
            this.HargaPerTiket.DataPropertyName = "HargaPerTiket";
            this.HargaPerTiket.HeaderText = "Harga (IDR)";
            this.HargaPerTiket.MinimumWidth = 6;
            this.HargaPerTiket.Name = "HargaPerTiket";
            this.HargaPerTiket.Width = 120;
            // 
            // Tanggal
            // 
            this.Tanggal.DataPropertyName = "Tanggal";
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.MinimumWidth = 6;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 110;
            // 
            // Jam
            // 
            this.Jam.DataPropertyName = "Jam";
            this.Jam.HeaderText = "Waktu Penerbangan";
            this.Jam.MinimumWidth = 6;
            this.Jam.Name = "Jam";
            this.Jam.Width = 135;
            // 
            // BeliTiket
            // 
            this.BeliTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BeliTiket.HeaderText = "Aksi";
            this.BeliTiket.MinimumWidth = 6;
            this.BeliTiket.Name = "BeliTiket";
            this.BeliTiket.Text = "Beli Tiket";
            this.BeliTiket.UseColumnTextForButtonValue = true;
            this.BeliTiket.Width = 100;
            // 
            // Form10ListPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1120, 710);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form10ListPenerbangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines — Daftar Penerbangan";
            this.Load += new System.EventHandler(this.Form10ListPenerbangan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPenerbangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label passengerLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.CheckBox timeCheck1;
        private System.Windows.Forms.CheckBox timeCheck2;
        private System.Windows.Forms.CheckBox timeCheck3;
        private System.Windows.Forms.CheckBox timeCheck4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaPerTiket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam;
        private System.Windows.Forms.DataGridViewButtonColumn BeliTiket;
        private System.Windows.Forms.Panel headerPanel;
    }
}