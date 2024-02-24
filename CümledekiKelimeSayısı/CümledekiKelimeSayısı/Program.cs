using System;

namespace CümledekiKelimeSayısı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cümle yazınız!");
            string cümle = Console.ReadLine();
            string[] kelimeler = cümle.Split(' ');

            Console.WriteLine($"Kelime sayısı: {kelimeler.Length}");

            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }

            Console.ReadLine();
        }
    }
}
