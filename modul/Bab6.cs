using System;

public class Bab6
{
    public static void Jalankan()
    {
        Console.WriteLine("=== BAB 6: STRUKTUR DASAR PROGRAM C# ===");
        // Penjelasan: Memahami struktur dasar C# seperti using System, namespace, class Program, dan static void Main()[cite: 1].

        // Studi Kasus 1: Menampilkan nama sekolah[cite: 1]
        Console.WriteLine("\n[Studi Kasus 1] Menampilkan Nama Sekolah[cite: 1]:");
        Console.WriteLine("Sekolah: SMKN 2 Buduran");

        // Studi Kasus 2: Meminta nama pengguna lalu menampilkan sapaan[cite: 1]
        Console.WriteLine("\n[Studi Kasus 2] Meminta Nama Pengguna[cite: 1]:");
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Halo, {nama}! Selamat datang.");
    }
}