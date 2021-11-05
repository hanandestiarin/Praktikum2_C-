using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_3_1204025
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JUMLAH ANAK AYAM ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0 && n < 11)
            {
                for (int i = n; i > 0; i--)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah induknya", i);
                    }
                    else
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah {1}", i, i - 1);
                    }
                }
            }
            else
            {
                Console.WriteLine("jumlah ayamnya tidak boleh 0 atau lebih dari 10");
            }
        }
    }
}