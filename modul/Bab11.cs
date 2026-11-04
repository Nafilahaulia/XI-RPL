using System;

public class Bab11
{
    public static void Jalankan()
    {
        Console.WriteLine("=== BAB 11: PERULANGAN (LOOPING) PADA C# ===");
        // Penjelasan: Menggunakan struktur perulangan for, while, do...while untuk mengeksekusi blok kode berulang kali[cite: 1].

        // Latihan: Mencari bilangan genap 1-20[cite: 1]
        Console.WriteLine("\n[Latihan] Bilangan Genap 1-20[cite: 1]:");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0) Console.Write(i + " ");
        }
        Console.WriteLine();

        // --- MINI PROJEK BAB 11 ---
        Console.WriteLine("\n--- [MINI PROJEK BAB 11: INPUT NAMA SISWA BERULANG] ---");
        Console.Write("Masukkan jumlah siswa: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Nama siswa ke-{i}: ");
            string namaSiswa = Console.ReadLine();
        }
        Console.WriteLine("Penginputan data siswa selesai[cite: 1].");
    }
}