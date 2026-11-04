using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin__Design_
{
    public partial class Form7KodePromo : Form
    {
        public Form7KodePromo()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4Bandara bandara = new Form4Bandara();
            this.Close();
            bandara.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }
   

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form4Bandara bandara = new Form4Bandara();
            this.Close();
            bandara.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Form5Maskapai maskapai = new Form5Maskapai();
            this.Close();
            maskapai.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Form5Maskapai maskapai = new Form5Maskapai();
            this.Close();
            maskapai.Show();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Form6JadwalPenerbangan jadwal = new Form6JadwalPenerbangan();
            this.Close();
            jadwal.Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Form6JadwalPenerbangan jadwal = new Form6JadwalPenerbangan();
            this.Close();
            jadwal.Show();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan status = new Form8UbahStatusPenerbangan();
            this.Close();
            status.Show();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan status = new Form8UbahStatusPenerbangan();
            this.Close();
            status.Show();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }
    }
}
