using System;

public class Bab14
{
    public static void Jalankan()
    {
        Console.WriteLine("=== BAB 14: OBJECT-ORIENTED PROGRAMMING (OOP) ===");

        // Latihan: Class Buku dengan constructor
        Console.WriteLine("\n[Latihan] Class Buku:");
        Buku b = new Buku("Pemrograman C#", "Nafilah Aulia Salma");
        b.TampilkanInfo();

        // --- MINI PROJEK BAB 14 (BISA DIISI) ---
        Console.WriteLine("\n--- [MINI PROJEK BAB 14: OOP CLASS MOBIL] ---");
        Mobil m = new Mobil();

        Console.Write("Masukkan merk mobil pilihan Anda: ");
        m.Merk = Console.ReadLine();

        m.Jalan();
    }
}

// Class pendukung OOP Bab 14
class Buku
{
    public string Judul;
    public string Penulis;

    public Buku(string judul, string penulis)
    {
        Judul = judul;
        Penulis = penulis;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Judul Buku : {Judul}");
        Console.WriteLine($"Penulis    : {Penulis}");
    }
}

class Mobil
{
    public string Merk { get; set; }

    public void Jalan()
    {
        Console.WriteLine($"Mobil dengan merk {Merk} sedang berjalan di jalan raya.");
    }
}