using System;
using System.Collections.Generic;

namespace ModulAjarRPL
{
    class Program
    {
        // Fungsi Main Utama (Titik awal program dieksekusi)
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO SELURUH BAB MODUL PEMROGRAMAN C# ===\n");

            Bab1_PengenalanPemrograman();
            Console.WriteLine("\n----------------------------------\n");

            Bab2_Algoritma();
            Console.WriteLine("\n----------------------------------\n");

            Bab5_InstalasiDanNet();
            Console.WriteLine("\n----------------------------------\n");

            Bab6_StrukturDasar();
            Console.WriteLine("\n----------------------------------\n");

            Bab8_Operator();
            Console.WriteLine("\n----------------------------------\n");

            Bab9_InputOutput();
            Console.WriteLine("\n----------------------------------\n");

            Bab10_Percabangan();
            Console.WriteLine("\n----------------------------------\n");

            Bab11_Perulangan();
            Console.WriteLine("\n----------------------------------\n");

            Bab12_ArrayDanKoleksi();
            Console.WriteLine("\n----------------------------------\n");

            Bab13_Method();
            Console.WriteLine("\n----------------------------------\n");

            Bab14_OOP();

            Console.WriteLine("\n=== SEMUA DEMO SELESAI DIJALANKAN ===");
            Console.ReadKey(); // Agar jendela konsol tidak langsung tertutup
        }

        // ==========================================
        // BAB 1: PENGENALAN PEMROGRAMAN KOMPUTER
        // ==========================================
        static void Bab1_PengenalanPemrograman()
        {
            /*
             * Penjelasan Bab 1:
             * - using System: Memanggil pustaka standar C#.
             * - class Program: Tempat utama mendefinisikan kelas aplikasi.
             * - Main(): Titik awal eksekusi program[cite: 1].
             * - Console.WriteLine(): Menampilkan teks ke layar[cite: 1].
             */
            Console.WriteLine("[BAB 1] Pengenalan Pemrograman");
            Console.WriteLine("Hello World");
        }

        // ==========================================
        // BAB 2: ALGORITMA DALAM PEMROGRAMAN
        // ==========================================
        static void Bab2_Algoritma()
        {
            /*
             * Penjelasan Bab 2:
             * Menerapkan urutan logis penyelesaian masalah (menghitung luas persegi)
             * dengan menerima input data, memprosesnya, dan menampilkan output[cite: 1].
             */
            Console.WriteLine("[BAB 2] Algoritma (Simulasi Luas Persegi)");
            int sisi = 5; // Diberi nilai langsung agar berjalan otomatis tanpa input manual
            int luas = sisi * sisi;
            Console.WriteLine($"Sisi = {sisi}, Luas Persegi = {luas}");
        }

        // ==========================================
        // BAB 5: INSTALASI VISUAL STUDIO DAN .NET
        // ==========================================
        static void Bab5_InstalasiDanNet()
        {
            /*
             * Penjelasan Bab 5:
             * Membahas penggunaan IDE seperti Visual Studio untuk menulis 
             * dan mengeksekusi proyek Console App C#[cite: 1].
             */
            Console.WriteLine("[BAB 5] Instalasi Visual Studio dan .NET");
            Console.WriteLine("Halo Dunia! (dijalankan dari IDE Visual Studio)");
        }

        // ==========================================
        // BAB 6: STRUKTUR DASAR PROGRAM C#
        // ==========================================
        static void Bab6_StrukturDasar()
        {
            /*
             * Penjelasan Bab 6:
             * Mempelajari kerangka utuh program C# mulai dari namespace, 
             * kelas, hingga fungsi utama serta cara membaca input sederhana[cite: 1].
             */
            Console.WriteLine("[BAB 6] Struktur Dasar Program C#");
            string nama = "Siswa RPL";
            Console.WriteLine("Halo " + nama);
        }

        // ==========================================
        // BAB 8: OPERATOR DALAM C#
        // ==========================================
        static void Bab8_Operator()
        {
            /*
             * Penjelasan Bab 8:
             * Operator digunakan untuk mengolah data (aritmatika seperti + dan %, 
             * serta perbandingan seperti >)[cite: 1].
             */
            Console.WriteLine("[BAB 8] Operator dalam C#");
            int a = 20;
            int b = 6;

            Console.WriteLine("Penjumlahan (20 + 6) = " + (a + b));
            Console.WriteLine("Modulus (20 % 6) = " + (a % b));
            Console.WriteLine("Apakah 20 > 6? " + (a > b));
        }

        // ==========================================
        // BAB 9: INPUT DAN OUTPUT PADA C#
        // ==========================================
        static void Bab9_InputOutput()
        {
            /*
             * Penjelasan Bab 9:
             * Membahas konversi data input dengan TryParse untuk mencegah error 
             * serta penggunaan String Interpolation ($"...").
             */
            Console.WriteLine("[BAB 9] Input dan Output");
            string angkaTeks = "25";
            if (int.TryParse(angkaTeks, out int umurInput))
            {
                // String Interpolation menggunakan tanda $
                Console.WriteLine($"Berhasil konversi! Angka Anda adalah {umurInput}.");
            }
        }

        // ==========================================
        // BAB 10: PERCABANGAN (SELECTION) PADA C#
        // ==========================================
        static void Bab10_Percabangan()
        {
            /*
             * Penjelasan Bab 10:
             * Struktur kontrol keputusan menggunakan if, else if, dan else 
             * untuk memilih aksi berdasarkan kondisi tertentu[cite: 1].
             */
            Console.WriteLine("[BAB 10] Percabangan");
            int nilai = 80;

            if (nilai >= 85)
            {
                Console.WriteLine("Nilai " + nilai + " -> Predikat: A");
            }
            else if (nilai >= 75)
            {
                Console.WriteLine("Nilai " + nilai + " -> Predikat: B");
            }
            else
            {
                Console.WriteLine("Nilai " + nilai + " -> Predikat: C");
            }
        }

        // ==========================================
        // BAB 11: PERULANGAN (LOOPING) PADA C#
        // ==========================================
        static void Bab11_Perulangan()
        {
            /*
             * Penjelasan Bab 11:
             * Perulangan for digunakan untuk mengeksekusi blok kode 
             * secara berulang kali secara terstruktur[cite: 1].
             */
            Console.WriteLine("[BAB 11] Perulangan (Looping)");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Perulangan ke-" + i);
            }
        }

        // ==========================================
        // BAB 12: ARRAY DAN KOLEKSI DASAR PADA C#
        // ==========================================
        static void Bab12_ArrayDanKoleksi()
        {
            /*
             * Penjelasan Bab 12:
             * Array menyimpan kumpulan elemen dengan tipe data sejenis 
             * yang diakses melalui indeks mulai dari angka 0[cite: 1].
             */
            Console.WriteLine("[BAB 12] Array dan Koleksi");
            string[] namaSiswa = { "Andi", "Budi", "Sinta" };

            Console.WriteLine("Siswa kedua (indeks 1): " + namaSiswa[1]);
        }

        // ==========================================
        // BAB 13: METHOD (FUNGSI) PADA C#
        // ==========================================
        static int HitungLuas(int p, int l)
        {
            return p * l; // Mengembalikan nilai (non-void)
        }

        static void Bab13_Method()
        {
            /*
             * Penjelasan Bab 13:
             * Method mengelompokkan perintah menjadi satu blok tugas 
             * agar dapat dipanggil kembali dengan parameter dan nilai balik[cite: 1].
             */
            Console.WriteLine("[BAB 13] Method (Fungsi)");
            int hasilLuas = HitungLuas(5, 4);
            Console.WriteLine("Hasil luas dari method HitungLuas(5, 4) = " + hasilLuas);
        }

        // ==========================================
        // BAB 14: OBJECT-ORIENTED PROGRAMMING (OOP)
        // ==========================================
        class SiswaSekolah
        {
            public string Nama { get; set; }

            public void Kenalan()
            {
                Console.WriteLine("Halo, saya siswa bernama " + Nama);
            }
        }

        static void Bab14_OOP()
        {
            /*
             * Penjelasan Bab 14:
             * OOP memodelkan program menjadi objek yang memiliki atribut 
             * (properti) dan perilaku (method)[cite: 1].
             */
            Console.WriteLine("[BAB 14] Object-Oriented Programming (OOP)");

            SiswaSekolah siswaBaru = new SiswaSekolah();
            siswaBaru.Nama = "Nafilah Aulia";
            siswaBaru.Kenalan();
        }
    }
}