// Materi Array dan Koleksi Dasar

// Pada Materi ini kita akan mempelajari:
// Array
// List
// serta menyimpan banyak data dalam satu tempat

// 1. Array
// Digunakan untuk menyimpan banya data dalam satu variabel
// Array biasanya digunakan ketika data memiliki tipe yang sama

// Array dapat menyimpan banyak data dengan tipe data yang sama

string[] namaBuah = { "Apel", "Jeruk", "Mangga", "Pisang" }; // Array string untuk menyimpan beberapa nama buah

// penjelasan struktur array
// string[]  <- tanda [] menunjukkan bahwa variabel adalah array

// Mengambil data dari array
//Console.WriteLine(namaBuah[0]); // hasilnya akan menampilkan apel (isi pertama array) karena index array dimulai dari angka 0
//Console.WriteLine(namaBuah[2]);

// Array juga sering digunakan bersama dengan perulangan foreach

foreach (string buah in namaBuah)
{
    Console.WriteLine(buah);
}

// Dengan pengulangan, kita dapat menghemat penulisan array tanpa harus menulis satu persatu


// 2. Koleksi Dasar: List
// adalah koleksi data yang lebih fleksibel dibandingkan array

List<string> namaSiswa = new List<string>(); // Membuat list kosong untuk menyimpan nama siswa

// Menambahkan data ke dalam list
namaSiswa.Add("Budi"); // .Add digunakan untuk menambahkan data ke dalam list
namaSiswa.Add("Anton");
namaSiswa.Add("Siti");

// Coba kita tampilkan hasil dari list
foreach (string siswa in namaSiswa)
{
    Console.WriteLine(siswa);
}

// Bedanya dengan array, ukuran dari list lebih fleksibel dibandingkan dengan array yang memiliki ukuran tetap
// dan cocok untuk data yang sering berubah-ubah (Dinamis)

//Dengan ini kita sudah mempelajari array dan koleksi dasar untuk menyimpan data di satu tempat.