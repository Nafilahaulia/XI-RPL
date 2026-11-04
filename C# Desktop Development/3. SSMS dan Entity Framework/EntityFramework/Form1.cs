using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        // Variabel penampung konteks database dan ID terpilih
        SekolahDBEntities db = new SekolahDBEntities();
        private int selectedSiswaId = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            RefreshDataGrid();

            // Konfigurasi dropdown pilihan jurusan
            jurusanBox.DataSource = db.Jurusans.ToList();
            jurusanBox.DisplayMember = "NamaJurusan";
            jurusanBox.ValueMember = "Id";
            jurusanBox.SelectedIndex = -1;
        }

        // Fungsi khusus untuk memperbarui tampilan data siswa pada grid
        private void RefreshDataGrid()
        {
            dataGridView1.DataSource = db.Siswas.Select(s => new
            {
                s.Id,
                s.Nama,
                s.Umur,
                s.Alamat,
                Jurusan = s.Jurusan.NamaJurusan
            }).ToList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Validasi kelengkapan input form
            if (string.IsNullOrWhiteSpace(namaText.Text) ||
                string.IsNullOrWhiteSpace(umurText.Text) ||
                string.IsNullOrWhiteSpace(alamatText.Text) ||
                jurusanBox.SelectedIndex == -1)
            {
                MessageBox.Show("Mohon lengkapi seluruh data formulir!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Logika simpan data baru atau perbarui data lama
            if (addBtn.Text == "Update")
            {
                var siswaExist = db.Siswas.Find(selectedSiswaId);
                if (siswaExist != null)
                {
                    siswaExist.Nama = namaText.Text;
                    siswaExist.Umur = Convert.ToInt32(umurText.Text);
                    siswaExist.Alamat = alamatText.Text;
                    siswaExist.JurusanID = Convert.ToInt32(jurusanBox.SelectedValue);

                    db.SaveChanges();
                    MessageBox.Show("Informasi siswa berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mengembalikan tombol ke mode input biasa
                    addBtn.Text = "Simpan";
                    selectedSiswaId = -1;
                }
            }
            else
            {
                var siswaBaru = new Siswa
                {
                    Nama = namaText.Text,
                    Umur = Convert.ToInt32(umurText.Text),
                    Alamat = alamatText.Text,
                    JurusanID = Convert.ToInt32(jurusanBox.SelectedValue)
                };

                db.Siswas.Add(siswaBaru);
                db.SaveChanges();

                MessageBox.Show("Data siswa baru berhasil direkam!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Mengosongkan form input setelah aksi selesai
            ClearInputFields();
            RefreshDataGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Proteksi jika user menekan area header tabel agar tidak crash
            if (e.RowIndex < 0) return;

            string targetColumn = dataGridView1.Columns[e.ColumnIndex].Name;
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

            if (targetColumn == "update")
            {
                // Memuat data terpilih dari tabel ke kolom input form
                selectedSiswaId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                namaText.Text = selectedRow.Cells["Nama"].Value.ToString();
                umurText.Text = selectedRow.Cells["Umur"].Value.ToString();
                alamatText.Text = selectedRow.Cells["Alamat"].Value.ToString();
                jurusanBox.Text = selectedRow.Cells["Jurusan"].Value.ToString();

                addBtn.Text = "Update";
            }
            else if (targetColumn == "delete")
            {
                var konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus data siswa ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (konfirmasi == DialogResult.Yes)
                {
                    int targetId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    var targetSiswa = db.Siswas.Find(targetId);

                    if (targetSiswa != null)
                    {
                        db.Siswas.Remove(targetSiswa);
                        db.SaveChanges();

                        MessageBox.Show("Data siswa telah dihapus dari sistem.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                RefreshDataGrid();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = searchTxt.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                RefreshDataGrid();
                return;
            }

            // Prosedur pencarian data berdasarkan filter multi-kolom
            dataGridView1.DataSource = db.Siswas
                .Where(s => s.Nama.Contains(keyword) ||
                            s.Umur.ToString().Contains(keyword) ||
                            s.Alamat.Contains(keyword) ||
                            s.Jurusan.NamaJurusan.Contains(keyword))
                .Select(s => new
                {
                    s.Id,
                    s.Nama,
                    s.Umur,
                    s.Alamat,
                    Jurusan = s.Jurusan.NamaJurusan
                })
                .ToList();
        }

        // Fungsi opsional untuk membersihkan kolom ketik setelah submit data
        private void ClearInputFields()
        {
            namaText.Clear();
            umurText.Clear();
            alamatText.Clear();
            jurusanBox.SelectedIndex = -1;
        }
    }
}
