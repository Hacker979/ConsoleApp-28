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
            int chet = 0;
            int nechet = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    chet++;
                }
                else
                {
                    nechet++;
                }
            }
            Console.WriteLine($"четных = {chet}");
            Console.WriteLine($"нечетных = {nechet}");
            Console.WriteLine(chet > nechet ? "Четных больше" : chet < nechet ? "Нечетных больше" : "Четных и нечетных одинаково");
        }
        static void Mas()
        {
            int[] mas = new int[9];
            Random rand = new Random();

            for (int i = 0; i < mas.Length; i++)
            {
                
                mas[i] = rand.Next(1,20);
                Console.WriteLine($"mas[{i}] = {mas[i]}");
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