using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void PrintMas(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    Console.Write(mas[i] + " ");
                }
            }
        }
        static void Mas()
        {
            int[] mas = new int[14];

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"mas[{i}] = ");
                mas[i] = int.Parse(Console.ReadLine());
            }
            PrintMas(mas);
        }

        static void Main(string[] args)
        {
            Mas();

            Console.Read();
        }
    }
}