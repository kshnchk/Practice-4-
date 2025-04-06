/*
1.6.Создать программу для перевода числа N7 в десятичную
систему счисления.
Используйте при разработки программы пояснения к заданию 1.5.
*/

namespace задание_1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в системе счисления с основанием 7:");
            int sepNum = int.Parse(Console.ReadLine());

            int dNum = 0;
            int i = 0;

            while (sepNum > 0)
            {
                int d = sepNum % 10;
                dNum += d * (int)Math.Pow(7, i);
                sepNum /= 10;
                i++;
            }

            Console.WriteLine($"Десятичное число: {dNum}");
        }
    }
}
