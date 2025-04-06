/*
3.7.Известны оценки ученика по 10 предметам. Определить
среднюю оценку.
*/

namespace задание_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] grades = new double[10];
            double sum = 0.0;
            Console.WriteLine("Введите оценки ученика по 10 предметам:");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Оценка по предмету {i + 1}: ");
                grades[i] = Convert.ToDouble(Console.ReadLine());
                sum += grades[i];
            }
            double res = sum / grades.Length;
            Console.WriteLine($"Средняя оценка ученика: {res}"); 
        }
    }
}
