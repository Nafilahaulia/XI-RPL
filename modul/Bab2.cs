using System;

public class Bab2
{
    public static void Jalankan()
    {
        Console.WriteLine("=== BAB 2: ALGORITMA DALAM PEMROGRAMAN ===");
        // Penjelasan: Algoritma adalah urutan langkah logis, sistematis, dan terbatas untuk menyelesaikan masalah[cite: 1].

        // Studi Kasus: Menghitung rata-rata tiga nilai[cite: 1]
        Console.WriteLine("\n[Studi Kasus] Menghitung Rata-rata Tiga Nilai[cite: 1]:");
        double n1 = 80, n2 = 85, n3 = 90;
        double rata = (n1 + n2 + n3) / 3;
        Console.WriteLine($"Nilai 1: {n1}, Nilai 2: {n2}, Nilai 3: {n3}");
        Console.WriteLine($"Rata-rata = {rata}");

        // Latihan: Menghitung luas segitiga[cite: 1]
        Console.WriteLine("\n[Latihan] Menghitung Luas Segitiga[cite: 1]:");
        Console.Write("Masukkan Alas: ");
        double alas = Convert.ToDouble(Console.ReadLine());
        Console.Write("Masukkan Tinggi: ");
        double tinggi = Convert.ToDouble(Console.ReadLine());
        double luasSegitiga = 0.5 * alas * tinggi;
        Console.WriteLine($"Luas Segitiga = {luasSegitiga}");
    }
}