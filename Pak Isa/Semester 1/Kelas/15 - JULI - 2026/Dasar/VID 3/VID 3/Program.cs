// Variabel, Tipe Data, dan Operator Sederhana

int umur = 17; // <- Ini adalah bentuk Variabel di C#

string //  <- Ini adalah Tipe Data yang menentukan sebuah Variabel.
    nama = "John"; // <- setelah itu diikuti dengan (Nama Variabel) = (Nilai Variabel)

// VARIABEL
// Ada 5 Variabel yang sering digunakan di C#

// Integer (int) = Bilangan Bulat
int tahun = 2008;

// Double atau float = Bilangan Desimal
double tinggi = 170.5;

// Char = Karakter Tunggal
char nilai = 'A'; //beda dengan string, Char menggunakan satu petik (' ')

// String = Karakter atau Kata
string alamat = "Jl. Merdeka No. 123";

// Boolean = True atau False
bool gemarMembaca = true;
bool sudahMakan = false;



// Operator Sederhana
// Operasi sederhana untuk menjumlahkan, mengurangi, mengalikan, dan membagi dua bilangan, serta menampilkannya.

// Variabel
int a = 10;
int b = 20;

// Operasi sederhana untuk menjumlahkan, mengurangi, dan mengalikan

// Menjumlahkan
// Ada dua cara untuk mengoprasikan, yaitu dengan membuat variabel baru atau langsung menulis di dalam WriteLine

// Cara 1 membuat Variabel terlebih dahulu
int hasilPenjumlahan = a + b;
Console.WriteLine(hasilPenjumlahan);

// Hasilnya akan keluar di dalam Console CMD

// Cara ke 2 langsung menulis di dalam WriteLine
Console.WriteLine(a + b);

// Hasilnya akan sama saja 


// 2. Mengurangi
// sama seperti di atas, kita bisa menggunakan kedua cara tersebut

Console.WriteLine(a - b);


// 3. Mengalikan
// untuk mengalikan, kita menggunakan tanda bintang (*)

Console.WriteLine(a * b);

// 4. Membagi
// untuk pembagian dengan hasil desimal, kita juga harus mempunyai variabel dengan tipe data desimal seperti Float atau Double.
// untuk pembagian, kita menggunakan tanda garis miring (/)

Console.WriteLine(a / b);

// hasil akan menjadi angka bulat dan tidak akurat, kita harus mengganti atau membuat Variabel baru dengan tipe data double
// biasanya tipe data double dilanjutkan dengan angka di belakangnya, namun jika hasilnya bulat biarkan kosong tanpa nilai koma di belakang
double c = 12.0;
double d = 5.0;

Console.WriteLine(c / d);

// Dengan ini kita sudah mempelajari Variabel, Tipe Data, dan Operator Sederhana.