using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziSıralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Dizi = { 12, 22, 33, 52, 1, 42, 72, 528, 98 };
            int uzunluk = Dizi.Length;
            int geçici = 0;

            Console.WriteLine("Dizi: { 12, 22, 33, 52, 1, 42, 72, 528, 98 }");

            for (int i = 0; i < uzunluk - i - 1; i++)
            {
                for (int j = 0; j < uzunluk - 1; j++)
                {
                    if (Dizi[j] > Dizi[j + 1])
                    {
                        geçici = Dizi[j];
                        Dizi[j] = Dizi[j + 1];
                        Dizi[j + 1] = geçici;


                    }
                }
            }
            //Diziyi Consol da görüntülemek için her elemanı yazdır
            for (int i = 0; i < uzunluk; i++)
            {
                Console.WriteLine(Dizi[i] + " ");

            }

            Console.ReadLine();
        }
    }
}
