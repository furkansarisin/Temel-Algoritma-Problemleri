using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizidekiSayınınİndexiniBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };");
            int[] dizi = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int sayı = Convert.ToInt32(Console.ReadLine());

            int ilkİndex = 0;
            int sonİndex = dizi.Length -1;
            int index = -1;

            while (ilkİndex <= sonİndex)
            {
                int orta = (ilkİndex + sonİndex) / 2;
                if (dizi[orta] == sayı)
                {
                    index = orta;
                    break;
                }
                else if (dizi[orta] < sayı)
                {
                    ilkİndex = orta + 1;
                }
                else
                {
                    sonİndex = orta - 1;    
                }
            }
            if (index != -1)
            {
                Console.WriteLine($"Bulundu, indeks: {index}");
            }
            else
            {
                Console.WriteLine("Bulunamadı");
            }
            Console.ReadLine();



        }
    }
}
