// Method / fungsi sederhana

// Pada materi ini kita akan mempelajari:
// 1. Method / fungsi
// 2. Parameter
// 3. Return value


// 1. Method / fungsi
// adalah kumpulan code yang digunakan untuk menjalankan tugas tertentu
// dapat membantu program menjadi:
// - lebih rapih
// - lebih terstruktur
// - dan dapat digunakan kembali (Reuse)

//      void karena method tidak mengembalikan nilai (tanpa return Value)
static void Salam()
{
    Console.WriteLine("Hello World");
}

// Memanggil method tanpa return value dan tanpa parameter
Salam();


// 2. Method dengan Parameter
// Parameter digunakan untuk mengirim data ke method

static void Sapa(string nama) //parameter bertipe string
{
    Console.WriteLine("Halo " + nama); //Variabel Parameter dimasukkan ke dalam method
}

// Memanggil Method dengan parameter sesuai dengan tipe data parameter pada method yang kita buat sebelumnya
Sapa("Budi"); //Memanggil method Sapa dengan parameter "Budi")



// 3. Method dengan Return Value
// Method juga dapat mengembalikan nilai (Return Value)

//      int dan bukan void karena method memiliki return value
static int Tambah(int a, int b)  // Method akan menghasilkan nilai bertipe int
{
    return a + b; // return digunakan untuk mengembalikan hasil
}

// Memanggil method dengan return value
Console.WriteLine(Tambah(5, 7));

// Method digunakan untuk menjalankan tugas tertentu
// Parameter digunakan untuk menerima data
// return untuk mengembalikan nilai

// dengan ini kita sudah mempelajari Method / Fungsi dasar.
