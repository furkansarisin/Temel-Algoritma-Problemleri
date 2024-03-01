using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizidekiÇiftSayılarıTopla
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };

            int çiftToplam = çiftSayılarıTopla(dizi);

            Console.WriteLine("Çift sayıların toplamı: " + çiftToplam);
            Console.ReadLine();
        }
        static int çiftSayılarıTopla(int[] dizi)
        {
            int toplam = 0;
            foreach (var sayi in dizi)
            {
                if (sayi % 2 == 0)
                {
                    toplam += sayi;
                }
            }
            return toplam;
        }
    }
}
