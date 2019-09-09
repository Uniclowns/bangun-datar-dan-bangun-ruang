using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            bangundatar datar = new bangundatar();

            datar.luas_persegi();
            
            Console.WriteLine();

            datar.luas_segitiga();
            Console.WriteLine();

            datar.luas_lingkaran();

            bangunruang ruang = new bangunruang();

            ruang.volume_balok();
            Console.WriteLine();
            
            ruang.volume_kubus();
        }
    }
}
