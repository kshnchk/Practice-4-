/*
3.14. Вычислить сумму 1! + 2! + 3! + … + n!, где k! = 1 · 2 · 3 …· k, 
и k = 1, 2, …, n. Значение n вводится с клавиатуры: 1 < n <= 10.
*/

namespace задание_3._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial; 
            }
            Console.WriteLine($"Сумма 1! + 2! + ... + {n}! = {sum}");
        }
    }
}
