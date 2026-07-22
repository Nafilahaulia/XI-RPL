using System;

namespace TugasOOP
{
    //==================== KALKULATOR ====================
    class Kalkulator
    {
        public void MenuKalkulator()
        {
            Console.Write("Input a : ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Input b : ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("\n1. Tambah");
            Console.WriteLine("2. Kurang");
            Console.WriteLine("3. Kali");
            Console.WriteLine("4. Bagi");
            Console.Write("Pilih Operasi : ");
            int pilih = int.Parse(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("Hasil = " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Hasil = " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Hasil = " + (a * b));
                    break;
                case 4:
                    if (b != 0)
                        Console.WriteLine("Hasil = " + (a / b));
                    else
                        Console.WriteLine("Tidak bisa dibagi nol.");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak ada.");
                    break;
            }
        }
    }

    //==================== BANGUN DATAR ====================
    class BangunDatar
    {
        public void MenuBangunDatar()
        {
            Console.WriteLine("1. Luas Persegi");
            Console.WriteLine("2. Luas Persegi Panjang");
            Console.WriteLine("3. Luas Lingkaran");
            Console.Write("Pilih : ");
            int pilih = int.Parse(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.Write("Masukkan sisi : ");
                    double s = double.Parse(Console.ReadLine());
                    Console.WriteLine("Luas = " + (s * s));
                    break;

                case 2:
                    Console.Write("Masukkan panjang : ");
                    double p = double.Parse(Console.ReadLine());

                    Console.Write("Masukkan lebar : ");
                    double l = double.Parse(Console.ReadLine());

                    Console.WriteLine("Luas = " + (p * l));
                    break;

                case 3:
                    Console.Write("Masukkan jari-jari : ");
                    double r = double.Parse(Console.ReadLine());

                    Console.WriteLine("Luas = " + (3.14 * r * r));
                    break;

                default:
                    Console.WriteLine("Pilihan tidak ada.");
                    break;
            }
        }
    }

    //==================== BANGUN RUANG ====================
    class BangunRuang
    {
        public void MenuBangunRuang()
        {
            Console.WriteLine("1. Volume Kubus");
            Console.WriteLine("2. Volume Balok");
            Console.WriteLine("3. Volume Tabung");
            Console.Write("Pilih : ");
            int pilih = int.Parse(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.Write("Masukkan sisi : ");
                    double s = double.Parse(Console.ReadLine());

                    Console.WriteLine("Volume = " + (s * s * s));
                    break;

                case 2:
                    Console.Write("Masukkan panjang : ");
                    double p = double.Parse(Console.ReadLine());

                    Console.Write("Masukkan lebar : ");
                    double l = double.Parse(Console.ReadLine());

                    Console.Write("Masukkan tinggi : ");
                    double t = double.Parse(Console.ReadLine());

                    Console.WriteLine("Volume = " + (p * l * t));
                    break;

                case 3:
                    Console.Write("Masukkan jari-jari : ");
                    double r = double.Parse(Console.ReadLine());

                    Console.Write("Masukkan tinggi : ");
                    double tt = double.Parse(Console.ReadLine());

                    Console.WriteLine("Volume = " + (3.14 * r * r * tt));
                    break;

                default:
                    Console.WriteLine("Pilihan tidak ada.");
                    break;
            }
        }
    }

    //==================== ZODIAK ====================
    class Zodiak
    {
        public void CekZodiak()
        {
            Console.Write("Masukkan tanggal lahir : ");
            int tgl = int.Parse(Console.ReadLine());

            Console.Write("Masukkan bulan lahir (1-12): ");
            int bln = int.Parse(Console.ReadLine());

            if ((bln == 3 && tgl >= 21) || (bln == 4 && tgl <= 19))
                Console.WriteLine("Zodiak : Aries");
            else if ((bln == 4 && tgl >= 20) || (bln == 5 && tgl <= 20))
                Console.WriteLine("Zodiak : Taurus");
            else if ((bln == 5 && tgl >= 21) || (bln == 6 && tgl <= 20))
                Console.WriteLine("Zodiak : Gemini");
            else if ((bln == 6 && tgl >= 21) || (bln == 7 && tgl <= 22))
                Console.WriteLine("Zodiak : Cancer");
            else if ((bln == 7 && tgl >= 23) || (bln == 8 && tgl <= 22))
                Console.WriteLine("Zodiak : Leo");
            else if ((bln == 8 && tgl >= 23) || (bln == 9 && tgl <= 22))
                Console.WriteLine("Zodiak : Virgo");
            else if ((bln == 9 && tgl >= 23) || (bln == 10 && tgl <= 22))
                Console.WriteLine("Zodiak : Libra");
            else if ((bln == 10 && tgl >= 23) || (bln == 11 && tgl <= 21))
                Console.WriteLine("Zodiak : Scorpio");
            else if ((bln == 11 && tgl >= 22) || (bln == 12 && tgl <= 21))
                Console.WriteLine("Zodiak : Sagitarius");
            else if ((bln == 12 && tgl >= 22) || (bln == 1 && tgl <= 19))
                Console.WriteLine("Zodiak : Capricorn");
            else if ((bln == 1 && tgl >= 20) || (bln == 2 && tgl <= 18))
                Console.WriteLine("Zodiak : Aquarius");
            else
                Console.WriteLine("Zodiak : Pisces");
        }
    }

    //==================== MENU ====================
    class Menu
    {
        public void TampilkanMenu()
        {
            Kalkulator k = new Kalkulator();
            BangunDatar bd = new BangunDatar();
            BangunRuang br = new BangunRuang();
            Zodiak z = new Zodiak();

            int menu;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Kalkulator");
                Console.WriteLine("2. Bangun Datar");
                Console.WriteLine("3. Bangun Ruang");
                Console.WriteLine("4. Zodiak");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilih Menu : ");

                menu = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (menu)
                {
                    case 1:
                        k.MenuKalkulator();
                        break;

                    case 2:
                        bd.MenuBangunDatar();
                        break;

                    case 3:
                        br.MenuBangunRuang();
                        break;

                    case 4:
                        z.CekZodiak();
                        break;

                    case 5:
                        Console.WriteLine("Terima kasih.");
                        break;

                    default:
                        Console.WriteLine("Menu tidak tersedia.");
                        break;
                }

                if (menu != 5)
                {
                    Console.WriteLine("\nTekan tombol Tab...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (menu != 5);
        }
    }

    //==================== MAIN ====================
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.TampilkanMenu();
        }
    }
}