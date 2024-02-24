using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktöriyelHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Faktöriyeli hesaplanacak sayıyı girin: ");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int faktöriyel = 1;
            for (int i = 1; i <= sayı; i++)
            {
                faktöriyel *= i;
            }
            Console.WriteLine("Sayının faktöriyel değeri: " + faktöriyel);
            Console.ReadLine();
        }
    }
}
