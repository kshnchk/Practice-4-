/*
3.3. Напечатать «столбиком»:
а) все целые числа от 20 до 35;
б) квадраты всех целых чисел от 10 до b (значение b вводится с
клавиатуры; b > 10);
в) третьи степени всех целых чисел от a до 50 (значение a
вводится с клавиатуры; a < 50);
г) все целые числа от a до b (значения a и b вводятся с
клавиатуры; b < a).
*/

namespace задание_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a)");
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("б)");
            Console.Write("Введите число b (b > 10): ");
            int b2 = int.Parse(Console.ReadLine());
            for (int i = 10; i <= b2; i++)
            {
                int res2 = i * i;
                Console.WriteLine($"{i}**2 = {res2}");
            }

            Console.WriteLine("в)");
            Console.Write("Введите значение a (a < 50): ");
            int a3 = int.Parse(Console.ReadLine());
            for (int i = a3; i <= 50; i++)
            {
                int res3 = i * i * i; 
                Console.WriteLine($"{i}**3 = {res3}");
            }

            Console.WriteLine("г)");
            Console.Write("Введите число a (a > b): ");
            int a4 = int.Parse(Console.ReadLine()); ;
            Console.Write("Введите число b (b < a): ");
            int b4 = int.Parse(Console.ReadLine()); ;
            Console.WriteLine($"Целые числа от {a4} до {b4}:");
            for (int i = a4; i >= b4; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
