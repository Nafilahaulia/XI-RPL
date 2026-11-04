using System;

class Program
{
    static void Main(string[] args)
    {
        bool ulang = true;
        while (ulang)
        {
            Console.Clear();
            Console.WriteLine("==========================================================");
            Console.WriteLine("   MODUL AJAR DASAR PEMROGRAMAN C# - SMKN 2 BUDURAN KELAS X ");
            Console.WriteLine("==========================================================");
            Console.WriteLine("Pilih Bab yang ingin dijalankan:");
            Console.WriteLine("1. Bab 1  - Pengenalan Pemrograman Komputer[cite: 1]");
            Console.WriteLine("2. Bab 2  - Algoritma dalam Pemrograman[cite: 1]");
            Console.WriteLine("3. Bab 5  - Instalasi Visual Studio dan .NET[cite: 1]");
            Console.WriteLine("4. Bab 6  - Struktur Dasar Program C#[cite: 1]");
            Console.WriteLine("5. Bab 8  - Operator dalam C# (Lengkap Mini Projek)[cite: 1]");
            Console.WriteLine("6. Bab 9  - Input dan Output pada C#[cite: 1]");
            Console.WriteLine("7. Bab 10 - Percabangan (Selection) (Lengkap Mini Projek)[cite: 1]");
            Console.WriteLine("8. Bab 11 - Perulangan (Looping) (Lengkap Mini Projek)[cite: 1]");
            Console.WriteLine("9. Bab 12 - Array dan Koleksi Dasar (Lengkap Mini Projek)[cite: 1]");
            Console.WriteLine("10. Bab 13 - Method (Fungsi) (Lengkap Mini Projek)[cite: 1]");
            Console.WriteLine("11. Bab 14 - OOP dalam C# (Lengkap Mini Projek)[cite: 1]");
            Console.WriteLine("0. Keluar Program");
            Console.WriteLine("==========================================================");
            Console.Write("Masukkan pilihan nomor bab (0-11): ");

            string pilihan = Console.ReadLine();
            Console.Clear();

            switch (pilihan)
            {
                case "1": Bab1.Jalankan(); break;
                case "2": Bab2.Jalankan(); break;
                case "3": Bab5.Jalankan(); break;
                case "4": Bab6.Jalankan(); break;
                case "5": Bab8.Jalankan(); break;
                case "6": Bab9.Jalankan(); break;
                case "7": Bab10.Jalankan(); break;
                case "8": Bab11.Jalankan(); break;
                case "9": Bab12.Jalankan(); break;
                case "10": Bab13.Jalankan(); break;
                case "11": Bab14.Jalankan(); break;
                case "0":
                    ulang = false;
                    Console.WriteLine("Program selesai. Terima kasih!");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid!");
                    break;
            }

            if (pilihan != "0" && ulang)
            {
                Console.WriteLine("\nTekan Enter untuk kembali ke Menu Utama...");
                Console.ReadLine();
            }
        }
    }
}