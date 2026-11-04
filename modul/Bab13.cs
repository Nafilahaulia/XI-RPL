using System;

public class Bab13
{
    public static void Jalankan()
    {
        Console.WriteLine("=== BAB 13: METHOD (FUNGSI) PADA C# ===");

        // Latihan: Method menghitung keliling persegi
        double sisi = 5;
        Console.WriteLine($"\n[Latihan] Keliling Persegi (Sisi {sisi}) = {HitungKelilingPersegi(sisi)}");

        // --- MINI PROJEK BAB 13 (BISA DIISI) ---
        Console.WriteLine("\n--- [MINI PROJEK BAB 13: METHOD HITUNG RATA-RATA] ---");
        Console.Write("Masukkan Nilai 1: ");
        int val1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan Nilai 2: ");
        int val2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan Nilai 3: ");
        int val3 = Convert.ToInt32(Console.ReadLine());

        double hasilRataMethod = HitungRata(val1, val2, val3);
        Console.WriteLine($"Hasil Rata-rata dari ({val1}, {val2}, {val3}) = {hasilRataMethod}");
    }

    static double HitungKelilingPersegi(double s)
    {
        return 4 * s;
    }

    static double HitungRata(int a, int b, int c)
    {
        return (a + b + c) / 3.0;
    }
}