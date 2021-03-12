using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine(
                "Pilih menu calculator:\n\n" +
                "1. Penambahan\n" +
                "2. Pengurangan\n" +
                "3. Perkalian\n" +
                "4. Pembagian\n");

            Console.Write("Input nomor menu [1-4]: ");
            int menu = int.Parse(Console.ReadLine());

            if (menu <1 | menu >4)
            {
                Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
            }

            else
            {
                Console.Write("\nInputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); // proses casting

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); // proses casting

                Console.WriteLine(); // tambahkan baris kosong

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                        break;

                    case 2:
                        Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                        break;

                    case 3:
                        Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                        break;

                    case 4:
                        Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                        break;

                }
            }


            Console.WriteLine("\nTekan sembarang tombol untuk keluar");
            Console.ReadKey();
        }


        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }

    }
}