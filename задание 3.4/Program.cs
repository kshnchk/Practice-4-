/*
3.4.Напечатать числа следующим образом:
а)10 10.4
11 11.4
...
25 25.4
б)25 25.5 24.8
26 26.5 25.8
...
35 35.5 34.8
*/

namespace задание_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("а");
            for (int i = 10; i <= 25; i++)
            {
                double res1 = i + 0.4;
                Console.WriteLine($"{i} {res1}");
            }

            Console.WriteLine("б");
            for (int i = 25; i <= 35; i++)
            {
                double res21 = i + 0.5; 
                double res22 = i - 0.2;
                Console.WriteLine($"{i} {res21} {res22}");
            }

        }
    }
}
