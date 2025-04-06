/*
3.12. Составить программу возведения натурального числа в
квадрат, учитывая следующую закономерность:
1**2 = 1, 2**2 = 1 + 3, 3**2 = 1 + 3 + 5, 4**2 = 1 + 3 + 5 + 7, …, n**2 = 1 + 3 + 5 + 7 + 9 + … + (2n — 1) .
*/

namespace задание_3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.Write("Введите натуральное число: ");
            int n = int.Parse(Console.ReadLine());
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                res += (2 * i - 1);
            }
            Console.WriteLine($"{n}**2 = {res}");
        }
    }
}
