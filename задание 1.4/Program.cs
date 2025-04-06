/*
1.4.Создать программу для перевода целого числа N из
десятичной в пятеричную систему счисления (CC).
Используйте при разработки программы пояснения к заданию 1.3. 
*/

namespace задание_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            string b5 = "";

            while (N > 0)
            {
                int r = N % 5;
                b5 = r.ToString() + b5;
                N /= 5;
            }

            Console.WriteLine($"Число в пятеричной системе: {b5}");

        }
    }
}
