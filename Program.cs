using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Sort(int[] mas)
        {
            int temp = 0;
            int a = mas[0];
            int max = 0;
            for (int i = 1; i < mas.Length; i++)
            {
                if (a < mas[i])
                {
                    a = mas[i];
                    max = i;
                }
            }

            Console.WriteLine($"\nmax: mas[{max}] = {mas[max]}");

            temp = mas[max];
            mas[max] = mas[0];
            mas[0] = temp;


        }
        static void PrintMas(int[] mas)
        {
            foreach (int i in mas)
            {
                Console.Write(i + " ");
            }
        }
        static void Mas()
        {
            int[] mas = new int[8] {3,5,4,3,8,6,5,9 };

            PrintMas(mas);
            Sort(mas);
            Console.Write("\nпоменять местами максимальный и первый элементы: ");
            PrintMas(mas);
        }

        static void Main(string[] args)
        {
            Mas();

            Console.Read();
        }
    }
}