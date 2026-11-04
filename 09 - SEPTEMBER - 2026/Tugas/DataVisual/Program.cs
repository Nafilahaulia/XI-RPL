using System;
namespace DataVisual
{
class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== WELCOME TO DATAVISUAL ===\n");

            Identitas identitas = new Identitas();
            MataPelajaran mapel = new MataPelajaran();
            Absensi absensi = new Absensi();
            NilaiSiswa nilai = new NilaiSiswa();

            Console.WriteLine("=== IDENTITAS SISWA ===");
            identitas.nama();
            identitas.nisn();
            identitas.alamat();
            identitas.wali();
            identitas.riwayatpendidikan();
            identitas.kelas();

            Console.WriteLine("\n=== MATA PELAJARAN PRODUKTIF ===");
            mapel.produktif();

            Console.WriteLine("\n=== MATA PELAJARAN NON PRODUKTIF ===");
            mapel.nonProduktif();

            Console.WriteLine("\n=== ABSENSI JANUARI ===");
            absensi.Januari();

            Console.WriteLine("\n=== ABSENSI FEBRUARI ===");
            absensi.Februari();

            Console.WriteLine("\n=== ABSENSI MARET ===");
            absensi.Maret();

            Console.WriteLine("\n=== ABSENSI APRIL ===");
            absensi.April();

            Console.WriteLine("\n=== ABSENSI MEI ===");
            absensi.Mei();

            Console.WriteLine("\n=== ABSENSI JUNI ===");
            absensi.Juni();

            Console.WriteLine("\n=== ABSENSI JULI ===");
            absensi.Juli();

            Console.WriteLine("\n=== ABSENSI AGUSTUS ===");
            absensi.Agustus();

            Console.WriteLine("\n=== ABSENSI SEPTEMBER ===");
            absensi.September();

            Console.WriteLine("\n=== ABSENSI OKTOBER ===");
            absensi.Oktober();

            Console.WriteLine("\n=== ABSENSI NOVEMBER ===");
            absensi.November();

            Console.WriteLine("\n=== ABSENSI DESEMBER ===");
            absensi.Desember();

            Console.WriteLine("\n=== NILAI PRODUKTIF ===");
            nilai.produktif();

            Console.WriteLine("\n=== NILAI NON PRODUKTIF ===");
            nilai.nonProduktif();

            Console.ReadLine();
        }
    }

    class Identitas
    {
        public void nama()
        {
        Console.WriteLine("Nafilah Aulia Salma");
        }

        public void nisn()
        {
        Console.WriteLine("0987654321");
        }

        public void alamat()
        {
            Console.WriteLine("Jl. Siwalanpanji");
        }

        public void wali()
        {
            Console.WriteLine("Mochamad Fadil");
        }

        public void riwayatpendidikan()
        {
            Console.WriteLine("TK Faqih Hasyim");
            Console.WriteLine("SDN Siwalanpanji");
            Console.WriteLine("MTsN 1 Sidoarjo");
        }

        public void kelas()
        {
            Console.WriteLine("XI RPL ");
        }
    }

    class MataPelajaran
    {
        public void produktif()
        {
            Console.WriteLine("PPLG");
            Console.WriteLine("Matematika");
            Console.WriteLine("Bahasa Inggris");
            Console.WriteLine("Bahasa Jepang");
            Console.WriteLine("KIK");
            Console.WriteLine("Bahasa Jerman");
            Console.WriteLine("Bahasa Jawa");

        }

        public void nonProduktif()
        {
            Console.WriteLine("Pendidikan Agama");
            Console.WriteLine("Pendidikan Pancasila");
            Console.WriteLine("Olahraga");
            Console.WriteLine("Bahasa Indonesia");
            Console.WriteLine("BK");
            Console.WriteLine("Sejarah");
        }
    }

    class Absensi
    {
        public void Januari()
        {
            Console.WriteLine("Hadir: 20 hari");
            Console.WriteLine("Sakit: 2 hari");
            Console.WriteLine("Izin: 1 hari");
            Console.WriteLine("Alfa: 0 hari");
        }

        public void Februari()
        {
            Console.WriteLine("Hadir: 18 hari");
            Console.WriteLine("Sakit: 1 hari");
            Console.WriteLine("Izin: 2 hari");
            Console.WriteLine("Alfa: 1 hari");
        }

        public void Maret()
        {
            Console.WriteLine("Hadir: 22 hari");
            Console.WriteLine("Sakit: 0 hari");
            Console.WriteLine("Izin: 1 hari");
            Console.WriteLine("Alfa: 0 hari");
        }

        public void April()
        {
            Console.WriteLine("Hadir: 19 hari");
            Console.WriteLine("Sakit: 1 hari");
            Console.WriteLine("Izin: 2 hari");
            Console.WriteLine("Alfa: 0 hari");
        }

        public void Mei()
        {
            Console.WriteLine("Hadir: 21 hari");
            Console.WriteLine("Sakit: 0 hari");
            Console.WriteLine("Izin: 1 hari");
            Console.WriteLine("Alfa: 0 hari");
        }

        public void Juni()
        {
            Console.WriteLine("Hadir: 20 hari");
            Console.WriteLine("Sakit: 1 hari");
            Console.WriteLine("Izin: 1 hari");
            Console.WriteLine("Alfa: 0 hari");
        }

        public void Juli()
        {
            Console.WriteLine("Hadir: 21 hari");
            Console.WriteLine("Sakit: 1 hari");
            Console.WriteLine("Izin: 1 hari");
            Console.WriteLine("Alfa: 0 hari");
        }

        public void Agustus()
        {
            Console.WriteLine("Hadir: 20 hari");
            Console.WriteLine("Sakit: 2 hari");
            Console.WriteLine("Izin: 1 hari");
            Console.WriteLine("Alfa: 0 hari");
        }

        public void September()
        {
            Console.WriteLine("Hadir: 20 hari");
            Console.WriteLine("Sakit: 0 hari");
            Console.WriteLine("Izin: 2 hari");
            Console.WriteLine("Alfa: 0 hari");
        }

        public void Oktober()
        {
            Console.WriteLine("Hadir: 19 hari");
            Console.WriteLine("Sakit: 1 hari");
            Console.WriteLine("Izin: 3 hari");
            Console.WriteLine("Alfa: 0 hari");
        }

        public void November()
        {
            Console.WriteLine("Hadir: 19 hari");
            Console.WriteLine("Sakit: 1 hari");
            Console.WriteLine("Izin: 2 hari");
            Console.WriteLine("Alfa: 0 hari");
        }

        public void Desember()
        {
            Console.WriteLine("Hadir: 22 hari");
            Console.WriteLine("Sakit: 1 hari");
            Console.WriteLine("Izin: 0 hari");
            Console.WriteLine("Alfa: 0 hari");
        }
    }

    class NilaiSiswa
    {
        public void produktif()
        {
            Console.WriteLine("PPLG              : 90");
            Console.WriteLine("Matematika        : 85");
            Console.WriteLine("Bahasa Inggris    : 88");
            Console.WriteLine("Bahasa Jepang     : 87");
            Console.WriteLine("KIK               : 90");
            Console.WriteLine("Bahasa Jerman     : 86");
            Console.WriteLine("Bahasa Jawa       : 89");
            Console.WriteLine();
        }

        public void nonProduktif()
        {
            Console.WriteLine("Pendidikan Agama      : 90");
            Console.WriteLine("Pendidikan Pancasila  : 88");
            Console.WriteLine("Olahraga              : 92");
            Console.WriteLine("Bahasa Indonesia      : 89");
            Console.WriteLine("BK                    : 90");
            Console.WriteLine("Sejarah               : 87");
        }
    }

}