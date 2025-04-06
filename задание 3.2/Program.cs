/*
3.2.Составить программу вывода любого числа любое заданное
число раз в виде, аналогичном показанному в предыдущей задаче.
*/

namespace задание_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ряда: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            string M = (Console.ReadLine());
            string res = new string(' ', 0);
            for (int i = 0; i < N; i++)
            {
                res += M + " ";
            }
            Console.WriteLine(res.Trim());
        }
    }
}
