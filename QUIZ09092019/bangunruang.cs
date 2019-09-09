using System;

namespace QUIZ09092019
{
    class bangunruang
    {
        public void volume_balok()
        {
            Console.WriteLine("Menghitung Volume Balok");

            int panjang,lebar,tinggi,volume;

            Console.WriteLine("Masukkan Nilai Panjang");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan Nilai Lebar");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan Nilai Tinggi");
            tinggi = Convert.ToInt32(Console.ReadLine());

            volume = panjang * lebar * tinggi;
            Console.WriteLine("Nilai Volume Adalah "+volume);
        }

        public void volume_kubus()
        {
            Console.WriteLine("Menghitung Volume Kubus");
            
            int rusuk,volume2;

            Console.WriteLine("Masukkan Nilai Rusuk");
            rusuk = Convert.ToInt32(Console.ReadLine());

            volume2 = rusuk * rusuk * rusuk;
            Console.WriteLine("Nilai Rusuk adalah "+volume2);
        }
    }
}