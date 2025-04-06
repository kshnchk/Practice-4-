/*
2.1.Создать программу, которая запрашивает у пользователя
числа до тех пор, пока он не введет 0 Вычислите и выведите
сумму всех введенных чисел.
*/

namespace задание_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;

            do
            {
                Console.WriteLine("Введите число (0 для выхода):");
                num = int.Parse(Console.ReadLine());
                sum += num;
            } while (num != 0);

            Console.WriteLine($"Сумма всех введенных чисел: {sum}");
        }
    }
}
