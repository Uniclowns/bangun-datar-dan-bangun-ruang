using System;

namespace QUIZ09092019
{
    class bangundatar
    {
        public void luas_persegi()
        {
            Console.WriteLine("Menghitung Luas Persegi");
            
            int sisi,luas;

            Console.WriteLine("Masukkan Nilai Sisi");
            sisi = Convert.ToInt32(Console.ReadLine());

            luas = sisi * sisi;
            Console.WriteLine("Nilai Luas adalah "+luas);
        }

        public void luas_segitiga()
        {
            Console.WriteLine("Menghitung Luas Segitiga");

            int alas,tinggi,luas2;

            Console.WriteLine("Masukkan Nilai Alas");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan Nilai Tinggi");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas2 = alas * tinggi / 2;

            Console.WriteLine("Nilai Luas adalah "+luas2);
        }

        public void luas_lingkaran()
        {
            Console.WriteLine("Menghitung Luas Lingkaran");
            

            int r;
            double luas3;

            Console.WriteLine("Masukkan Nilai Jari-Jari");
            r = Convert.ToInt32(Console.ReadLine());

            luas3 =  3.14 * r * r;

            Console.WriteLine("Nilai Luas adalah "+luas3);

        }

        
    }
}