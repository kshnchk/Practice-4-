/*
3.1.Напечатать ряд чисел 20 длины N (N – число вводимое с
клавиатуры) в виде:
20 20 20 20 20 20 20 20 20 20 (Длина ряда 10)
*/

namespace задание_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ряда: ");
            int N = int.Parse(Console.ReadLine());
            string res = new string(' ', 0);
            for (int i = 0; i < N; i++)
            {
                res += "20 "; 
            }
            Console.WriteLine(res.Trim());  
        }
    }
}
