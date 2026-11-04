using System;
namespace Matematika
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Belajar PBO");

            Kalkulator kal = new Kalkulator();
            BangunDatar bdatar = new BangunDatar();
            BangunRuang bruang = new BangunRuang();

            // Kalkulator
            kal.penjumlahan();
            kal.pengurangan();
            kal.perkalian();
            kal.Pembagian();

            // Bangun Datar
            BangunDatar.kelilingPersegiPanjang();
            BangunDatar.kelililngLingkaran();
            BangunDatar.luasPersegiPanjang();
            BangunDatar.luasLingkaran();

            // Bangun Ruang
            bruang.volumeBalok();
            bruang.volumeTabung();
            bruang.volumePiramida();

            Console.ReadKey();
        }
    }

    class Kalkulator
    {
        public void penjumlahan()
        {
            Console.WriteLine("Penjumlahan");
        }

        public void pengurangan()
        {
            Console.WriteLine("Pengurangan");
        }

        public void perkalian()
        {
            Console.WriteLine("Perkalian");
        }

        public void Pembagian()
        {
            Console.WriteLine("Pembagian");
        }
    }

    class BangunDatar
    {
        public static void kelilingPersegiPanjang()
        {
            Console.WriteLine("Keliling Persegi Panjang");
        }

        public static void kelililngLingkaran()
        {
            Console.WriteLine("Keliling Lingkaran");
        }

        public static void luasPersegiPanjang()
        {
            Console.WriteLine("Luas Persegi Panjang");
        }

        public static void luasLingkaran()
        {
            Console.WriteLine("Luas Lingkaran");
        }
    }

    class BangunRuang
    {
        public void volumeBalok()
        {
            Console.WriteLine("Volume Balok");
        }

        public void volumeTabung()
        {
            Console.WriteLine("Volume Tabung");
        }

        public void volumePiramida()
        {
            Console.WriteLine("Volume Piramida");
        }
    }
}