using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
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
            int[] mas = new int[9];
            Random rand = new Random();

            for (int i = 0; i < mas.Length; i++)
            {
                
                mas[i] = rand.Next(1,20);
                Console.Write($"mas[{i}] = {mas[i]}");
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