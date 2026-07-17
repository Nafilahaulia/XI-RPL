// Materi Perulangan For, While, dan Foreach

//Perulangan digunakan untuk menjalanjan perintah berulang otomatis
// dengan perulangan, program dapat menghemat penulisan Code



//FOR
//Digunakan ketika jumlah perulangan sudah diketahui

//For digunakan untuk perulangan dengan jumlah tertentu

//Isi (Parameter) dari For Loop
//int i = 1      <- Nilai awal perulangan
//i <= 5         <- Kondisi selama perulangan berjalan
//i++            <- Menambah nilai i setiap perulangan


for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Perulangan Ke - " + i); // Artinya code diulang selama variabel i kurang dari atau sama dengan 5
}



//2. While Loop
//digunakan ketika jumlah perulangan tidak diketahui, dan perulangan akan terus berjalan selama kondisi bernilai true

int angka = 1;

while (angka <= 5) //While akan berjalan selama kondisi bernilai true
{
    Console.WriteLine("Perulangan Ke - " + angka);
    angka++; // Increment wajib, agar perulangan tidak berjalan terus menerus
             // Jika increment tidak ditambahkan, program dapat mengalami infinite loop (perulangan tanpa henti)
}

// nilai variabel angka akan tetap 1 sedangkan Write Line tetap terus berjalan

// 3. Foreach Loop
// Digunakan untuk mengambil data dari kumpulan data seperti array atau List (Array akan kita bahas dimateri selanjutnya)

// Foreach membaca data satu persatu dari array

string[] namaBuah = { "Apel", "Jeruk", "Mangga", "Pisang" };

foreach (string buah in namaBuah) // variabel buah pada paramater foreach akan berisi data dari array namaBuah
{
    Console.WriteLine(buah);
}

// Dengan ini kita sudah mempelajari pengulangan menggunakan For Loop, While Loop, serta Foreach Loop