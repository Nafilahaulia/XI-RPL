using System;

public class Bab10
{
    public static void Jalankan()
    {
        Console.WriteLine("=== BAB 10: PERCABANGAN (SELECTION) PADA C# ===");
        // Penjelasan: Menggunakan struktur if, else if, else, dan switch untuk mengambil keputusan berdasarkan kondisi[cite: 1].

        // Studi Kasus: Menentukan kategori nilai siswa[cite: 1]
        Console.WriteLine("\n[Studi Kasus] Menentukan Kategori Nilai Siswa[cite: 1]:");
        int nilai = 85;
        if (nilai >= 85) Console.WriteLine("Kategori: Sangat Baik");
        else Console.WriteLine("Kategori: Cukup");

        // --- MINI PROJEK BAB 10 ---
        Console.WriteLine("\n--- [MINI PROJEK BAB 10: SYARAT PEMBUATAN KTP] ---");
        Console.Write("Masukkan Umur: ");
        int umurKTP = Convert.ToInt32(Console.ReadLine());
        if (umurKTP >= 17)
        {
            Console.WriteLine("Boleh membuat KTP[cite: 1]");
        }
        else
        {
            Console.WriteLine("Belum memenuhi syarat[cite: 1]");
        }
    }
}