// Materi Percabangan

// Mempelajari percabangan: IF, Else, Else If, dan Switch


// Percabangan digunakan untuk mengambil keputusan pada program
// Program dapat menjalankan perintah berbeda tergantung kondisi tertentu

//  IF
int umur = 20;

if (umur >= 18) // If digunakan untuk mengecek kondisi,
                // Kondisi akan menghasilkan true atau false
{
    Console.WriteLine("Boleh membuat KTP"); // ini output jika hasilnya true
}
else // Else dijalankan jika kondisi false
     // Else digunakan sebagai alternatif jika kondisi pada IF tidak terpenuhi
{
    Console.WriteLine("Belum boleh membuat KTP"); // ini output jika hasilnya false
}


// ELSE IF

int nilai = 85;

if (nilai >= 90)
{
    Console.WriteLine("Grade A");
}
else if (nilai >= 75) // Else If digunakan untuk menambah kondisi lain
                      // Else If memungkinkan program memeriksa beberapa kondisi berbeda
{
    Console.WriteLine("Grade B");
}
else
{
    Console.WriteLine("Grade C");
}


// Switch

// Digunakan untuk memilih kondisi berdasarkan nilai tertentu

string hari = "Senin";

switch (hari) // switch digunakan untuk memeriksa nilai dari variabel
{
    case "Senin": // case adalah pilihan kondisi
        Console.WriteLine("Hari Pertama");
        break; // break digunakan untuk menghentikan switch

    case "Minggu":
        Console.WriteLine("Hari Ketujuh");
        break;

    default: // default dijalankan jika tidak ada kondisi yang cocok (mirip seperti false di Else If)
        Console.WriteLine("Hari Lainnya");
        break;
}