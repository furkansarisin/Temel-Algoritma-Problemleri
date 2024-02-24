using System;

namespace AsalSayıKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kontrol etmek istediğiniz sayıyı giriniz: ");
            int sayı = Convert.ToInt32(Console.ReadLine());
            bool sonuc = true;

            for (int i = 2; i <= sayı / 2; i++)
            {
                if (sayı % i == 0)
                {
                    sonuc = false;
                    break; // Bölen bulunduğunda döngüden çık
                }
            }

            if (sonuc && sayı >= 2)
            {
                Console.WriteLine("Asal");
            }
            else
            {
                Console.WriteLine("Asal Değil");
            }

            Console.ReadLine();
        }
    }
}
