using System;
using System.Linq;
using System.Windows.Forms;

namespace ContohSoal1
{
    public partial class Form1Login : Form
    {
        BandaraEntities db = new BandaraEntities();

        public Form1Login()
        {
            InitializeComponent();
            UIHelper.Normalize(this);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2Register register = new Form2Register();
            this.Hide();
            register.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "" || passwordTxt.Text == "")
            {
                MessageBox.Show("Username dan Password harus diisi");
                return;
            }

            // Cari akun berdasarkan username dan password
            var user = db.Akuns.FirstOrDefault(a =>
                a.Username == usernameTxt.Text &&
                a.Password == passwordTxt.Text);

            // Cek user
            if (user == null)
            {
                MessageBox.Show("Password atau Username salah");
                return;
            }

            MessageBox.Show("Login Berhasil");

            Session.loggedIn = user;

            if (user.MerupakanAdmin)
            {
                Form3Dashboard dashboard = new Form3Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                Form9CustomerMain customer = new Form9CustomerMain();
                customer.Show();
                this.Hide();
            }
        }
    }
}