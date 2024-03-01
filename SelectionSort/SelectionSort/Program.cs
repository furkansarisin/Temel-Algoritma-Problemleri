using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi: { 12, 32, 2, 85, 23, 54, 73, 71, 24 };");
            int[] dizi = { 12, 32, 2, 85, 23, 54, 73, 71, 24 };
            int diziUzunluk = dizi.Length;

            for (int i = 0; i < diziUzunluk - 1; i++)
            {
                int küçükİndex = i;
                for (int j = i + 1; j < diziUzunluk; j++)
                {
                    if (dizi[j] < dizi[i])
                    {
                        küçükİndex = j;
                    }
                }
                int gecici = dizi[küçükİndex];
                dizi[küçükİndex] = dizi[i];
                dizi[i] = gecici;
            }
            //Diziyi Consol da görüntülemek için her elemanı yazdır
            for (int i = 0; i < diziUzunluk; i++)
            {
                Console.WriteLine(dizi[i] + " ");

            }

            Console.ReadLine();
        }
    }
}
