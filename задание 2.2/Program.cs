/*
2.2.Дополните код предыдущей задачи для создания программы
рассчитывающей среднее арифметическое последовательности.
*/

namespace задание_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            int c = 0;

            do
            {
                Console.WriteLine("Введите число (0 для выхода):");
                num = int.Parse(Console.ReadLine());
                sum += num;
                c++;
            } while (num != 0);

            double average = (double)(sum - 0) / (c - 1);
            Console.WriteLine($"Сумма всех введенных чисел: {sum}");
            Console.WriteLine($"Среднее арифметическое: {average}");

        }
    }
}
