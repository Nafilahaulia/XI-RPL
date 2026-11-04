using System;
namespace Jadwal
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jadwal Pelajaran");

            Senin senin = new Senin();
            senin.Sesi1();
            senin.Sesi2();
            senin.Sesi3();

            Selasa selasa = new Selasa();
            selasa.Sesi1();
            selasa.Sesi2();
            selasa.Sesi3();

            Rabu rabu = new Rabu();
            rabu.Sesi1();
            rabu.Sesi2();
            rabu.Sesi3();

            Kamis kamis = new Kamis();
            kamis.Sesi1();
            kamis.Sesi2();
            kamis.Sesi3();

            Jumat jumat = new Jumat();
            jumat.Sesi1();
            jumat.Sesi2();

        }
    }

    class Senin
    {
        public void Sesi1()
        {
            //Console.WriteLine("Bahasa Jepang 07.35 - 08.10");
            //Console.WriteLine("Bahasa Jepang 08.10 - 08.45");
            //Console.WriteLine("Bahasa Inggris 08.45 - 09.20");
            //Console.WriteLine("Bahasa Inggris 09.20 - 09.55");
            Console.WriteLine("Bahasa Jepang 07.35 - 08.45");

        }

        public void Sesi2()
        {
            Console.WriteLine("Matematika 10.10 - 11.40");
        }

        public void Sesi3()
        {
            Console.WriteLine("PPLG 12.30 - 14.30");
        }
    }

    class Selasa
    {
        public void Sesi1()
        {
            Console.WriteLine("KIK 07.00 - 08.10");
            Console.WriteLine("PJOK 08.10 - 09.20");
        }

        public void Sesi2()
        {
            Console.WriteLine("Bahasa Indonesia 09.30 - 11.05");
            Console.WriteLine("PPLG 11.05 - 11.35");
        }

        public void Sesi3()
        {
            Console.WriteLine("PPLG 12.30 - 14.00");
        }
    }

    class Rabu
    {
        public void Sesi1()
        {
            Console.WriteLine("PPLG 07.00 - 09.20");
        }

        public void Sesi2()
        {
            Console.WriteLine("PPLG 09.30 - 11.35");
        }

        public void Sesi3()
        {
            Console.WriteLine("PPLG 12.30 - 13.30");
            Console.WriteLine("BK 13.30 - 14.00");
        }
    }

    class Kamis
    {
        public void Sesi1()
        {
            Console.WriteLine("Bahasa Jerman 07.00 - 08.10");
            Console.WriteLine("Bahasa Jawa 08.10 - 09.20");
        }

        public void Sesi2()
        {
            Console.WriteLine("KIK 09.30 - 11.05");
            Console.WriteLine("PAI 11.05 - 11.35");
        }

        public void Sesi3()
        {
            Console.WriteLine("PAI 12.30 - 13.30");
        }
    }

    class Jumat
    {
        public void Sesi1()
        {
            Console.WriteLine("Bahasa Inggris 08.00 - 09.00");
            Console.WriteLine("Sejarah 09.00 - 09.30");
        }

        public void Sesi2()
        {
            Console.WriteLine("Sejarah 09.45 - 10.15");
            Console.WriteLine("Pendidikan Pancasila 10.15 - 11.15");
        }
    }

}