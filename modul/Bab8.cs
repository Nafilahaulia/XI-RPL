using System;

public class Bab8
{
    public static void Jalankan()
    {
        Console.WriteLine("=== BAB 8: OPERATOR DALAM C# ===");
        // Penjelasan: Operator digunakan untuk mengolah data menggunakan aritmatika, penugasan, perbandingan, dan logika[cite: 1].

        // Latihan: Menghitung luas persegi panjang[cite: 1]
        Console.WriteLine("\n[Latihan] Menghitung Luas Persegi Panjang[cite: 1]:");
        Console.Write("Masukkan Panjang: ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan Lebar: ");
        int l = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Luas Persegi Panjang = {p * l}");

        // --- MINI PROJEK BAB 8 ---
        Console.WriteLine("\n--- [MINI PROJEK BAB 8: TOTAL BELANJA] ---");
        Console.Write("Harga Barang: ");
        double harga = Convert.ToDouble(Console.ReadLine());
        Console.Write("Jumlah : ");
        int jumlah = Convert.ToInt32(Console.ReadLine());
        double total = harga * jumlah;
        Console.WriteLine($"Total = {total}[cite: 1]");
    }
}