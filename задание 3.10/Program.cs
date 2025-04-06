/*
3.10. Начав тренировки, лыжник в первый день пробежал 10
км. Каждый следующий день он увеличивал пробег на 10% от
пробега предыдущего дня. Определить:
а) пробег лыжника за второй, третий, …, десятый день тренировок;
б) какой суммарный тренировок.
*/

namespace задание_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("а)");
            double initialDistance = 10.0; 
            double[] distances = new double[10];
            double totalDistance = 0.0;
            distances[0] = initialDistance; 
            for (int day = 1; day < distances.Length; day++)
            {
                distances[day] = distances[day - 1] * 1.10;
            }
            Console.WriteLine("Пробег лыжника:");
            for (int day = 1; day < distances.Length; day++)
            {
                Console.WriteLine($"День {day + 1}: {distances[day]} км");
                totalDistance += distances[day];
            }

            Console.WriteLine("б)");
            Console.WriteLine($"Суммарный пробег за 10 дней: {totalDistance} км");
        }
    }
}
