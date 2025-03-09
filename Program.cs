using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static double Avg(double[] mas)
        {
            double sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            return sum / mas.Length;
        }
        static double Max(double[] mas)
        {
            double max = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                }
            }
            return max;
        }
        static double Min(double[] mas)
        {
            double min = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                }
            }
            return min;
        }
        static int MaxD(double[] mas, double max)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == max)
                {
                    return i + 1;
                }
            }
            return -1;
        }

        static int MinD(double[] mas, double min)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == min)
                {
                    return i + 1;
                }
            }
            return -1;
        }

        static void PrintMas(double[] mas)
        {
            foreach (double i in mas)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Среднее значение ЗП = {Avg(mas):F2}.");
            Console.WriteLine($"Максимальная ЗП в {MaxD(mas, Max(mas))} день равна {Max(mas):F2}.");
            Console.WriteLine($"Минимальная ЗП в {MinD(mas, Min(mas))} день равна {Min(mas):F2}.");
        }
        static void Mas()
        {
            double[] mas = new double[12] { 63.50, 63.20, 63.57, 62.87, 64.31, 63.50, 63.24, 64.12, 62.59, 63.78, 63.42, 63.77 };

            PrintMas(mas);
        }

        static void Main(string[] args)
        {
            Mas();

            Console.Read();
        }
    }
}