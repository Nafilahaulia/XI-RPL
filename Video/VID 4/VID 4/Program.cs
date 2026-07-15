int umur = 20;

if (umur >= 18)
{
    Console.WriteLine("Boleh membuat KTP");
}
else
{
    Console.WriteLine("Belum boleh membuat KTP");
}

int nilai = 85;

if (nilai >= 90)
{
    Console.WriteLine("Grade A");
}
else if (nilai >= 75)
{
    Console.WriteLine("Grade B");
}
else
{
    Console.WriteLine("Grade C");
}

string hari = "Senin";
switch (hari)
{
    case "Senin":
        Console.WriteLine("Hari Pertama");
        break;
    case "Minggu":
        Console.WriteLine("Hari Ketujuh");
        break;
    default:
        Console.WriteLine("Hari Lainnya");
        break;
}