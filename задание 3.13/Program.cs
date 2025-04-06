/*
3.13. Найти сумму 12 + 22 + 32 + … + 102 Операцию
возведения в степень не использовать, а учесть особенности
получения квадрата натурального числа, отмеченные в
предыдущей задаче.
*/

namespace задание_3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSum = 0; 
            for (int n = 1; n <= 10; n++)
            {
                int square = 0; 
                for (int i = 0; i < n; i++)
                {
                    square += (2 * i + 1); 
                }
                totalSum += square; 
            }
            Console.WriteLine($"Сумма 12 + 22 + 32 + ... + 102 = {totalSum}");
        }
    }
}
