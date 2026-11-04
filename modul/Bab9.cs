using System;

public class Bab9
{
    public static void Jalankan()
    {
        Console.WriteLine("=== BAB 9: INPUT DAN OUTPUT PADA C# ===");
        // Penjelasan: Memahami Console.Write/WriteLine, Console.ReadLine, serta konversi data dan string interpolation[cite: 1].

        // Latihan: Menghitung umur dari tahun lahir[cite: 1]
        Console.WriteLine("\n[Latihan] Menghitung Umur dari Tahun Lahir[cite: 1]:");
        Console.Write("Masukkan Tahun Lahir: ");
        int tahunLahir = Convert.ToInt32(Console.ReadLine());
        int umur = DateTime.Now.Year - tahunLahir;
        Console.WriteLine($"Estimasi Umur Anda: {umur} tahun.");
    }
}