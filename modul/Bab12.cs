using System;

public class Bab12
{
    public static void Jalankan()
    {
        Console.WriteLine("=== BAB 12: ARRAY DAN KOLEKSI DASAR PADA C# ===");

        // Latihan: Mencari nilai terbesar dalam array statis
        int[] arrNilai = { 75, 82, 95, 68, 90 };
        int max = arrNilai[0];
        foreach (int val in arrNilai) if (val > max) max = val;
        Console.WriteLine($"\n[Latihan] Nilai terbesar dalam array [75, 82, 95, 68, 90] adalah: {max}");

        // --- MINI PROJEK BAB 12 (BISA DIISI) ---
        Console.WriteLine("\n--- [MINI PROJEK BAB 12: RATA-RATA NILAI ARRAY] ---");
        Console.Write("Masukkan jumlah data nilai yang ingin dihitung: ");
        int jumlahData = Convert.ToInt32(Console.ReadLine());

        int[] nilaiMini = new int[jumlahData];
        int totalNilai = 0;

        for (int i = 0; i < jumlahData; i++)
        {
            Console.Write($"Masukkan nilai ke-{i + 1}: ");
            nilaiMini[i] = Convert.ToInt32(Console.ReadLine());
            totalNilai += nilaiMini[i];
        }

        double rataRata = jumlahData > 0 ? (double)totalNilai / jumlahData : 0;
        Console.WriteLine($"Total Keseluruhan = {totalNilai}");
        Console.WriteLine($"Rata-rata = {rataRata}");
    }
}