using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContohStatementSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilih;
           

            Console.WriteLine("MENU PERSEGI PANJANG");
            Console.WriteLine("1. Hitung Luas");
            Console.WriteLine("2. Hitung Keliling");
            Console.WriteLine("3. Hitung Panjang Diagonal");
            Console.Write("\nMenu Pilihan :  ");
            pilih = int.Parse(System.Console.ReadLine());
            Console.WriteLine();
            switch (pilih)
            {
                case 1:
                    int a; //panjang 
                    double b; // lebar 
                    double luas; // luas 
                    Console.WriteLine("\nLUAS PERSEGI PANJANG");
                    Console.Write("Masukkan Panjang : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan Lebar : ");
                    b = Convert.ToDouble(Console.ReadLine());
                    luas = a * b;
                    Console.WriteLine("\nLuas persegi panjang = " + luas);
                    Console.ReadKey();
                    break;

                case 2:
                    int x; //panjang 
                    double y; // lebar 
                    double keliling;
                    Console.WriteLine("KELILING PERSEGI PANJANG");
                    Console.Write("Masukkan Panjang : ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan Lebar : ");
                    y = Convert.ToDouble(Console.ReadLine());
                    keliling = (2 * x) + (2 * y);
                    Console.WriteLine("Keliling persegi panjang = " + keliling);
                    Console.ReadKey();
                    break;

                case 3:
                    int p; //panjang 
                    double l; // lebar 
                    double diagonal;
                    Console.WriteLine("PANJANG DIAGONAL");
                    Console.Write("Masukkan Panjang : ");
                    p = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan Lebar : ");
                    l = Convert.ToDouble(Console.ReadLine());
                    diagonal = p * p + l * l;
                    Console.WriteLine("Jumlah diagonal  " + diagonal );
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Tidak ada pilihan selain 1/2/3");
                    break;

            }
        }
    }
}