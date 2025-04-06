/*
3.8.Известна масса каждого предмета из некоторого набора
предметов. Определить среднюю массу.
*/

using System;

namespace задание_3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество предметов: ");
            int n = int.Parse(Console.ReadLine()); ;
            double[] thing = new double[n];
            double sum = 0.0;
            Console.WriteLine($"Введите вес {n} предметов:");
            for (int i = 0; i < thing.Length; i++)
            {
                Console.Write($"Вес предмета {i + 1}: ");
                thing[i] = Convert.ToDouble(Console.ReadLine());
                sum += thing[i];
            }
            double res = sum / thing.Length;
            Console.WriteLine($"Средний масса предметов: {res}");
        }
    }
}
