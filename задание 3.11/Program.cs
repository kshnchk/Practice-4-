/*
3.11. В некотором году (назовем его условно первым) на
участке площадью в 100 гектаров средняя урожайность ячменя
составила 20 центнеров с гектара. После этого каждый год
площадь участка увеличивалась на 5%, а средняя урожайность —
на 2%. Определить:
а) урожайность за второй, третий, …, восьмой год;
б) площадь участка в четвертый, пятый, …, седьмой год;
в) какой урожай будет собран за первые шесть лет.
*/

namespace задание_3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a)");
            double initialArea = 100.0; 
            double initialYield = 20.0;  
            double areaIncreaseRate = 0.05; 
            double yieldIncreaseRate = 0.02;
            Console.WriteLine("Урожайность ячменя за второй, третий, ..., восьмой год:");
            for (int year = 2; year <= 8; year++)
            {
                initialYield *= (1 + yieldIncreaseRate);
                Console.WriteLine($"Год {year}: {initialYield} центнеров");
            }

            Console.WriteLine("б)");
            Console.WriteLine("Площадь участка в четвертый, пятый, ..., седьмой год:");
            double currentArea = initialArea;
            for (int year = 4; year <= 7; year++)
            {
                currentArea *= (1 + areaIncreaseRate);
                Console.WriteLine($"Год {year}: {currentArea} гектаров");
            }

            Console.WriteLine("в)");
            double totalHarvest = 0.0;
            currentArea = initialArea; 
            initialYield = 20.0;

            for (int year = 1; year <= 6; year++)
            {
                totalHarvest += currentArea * initialYield;
                currentArea *= (1 + areaIncreaseRate);
                initialYield *= (1 + yieldIncreaseRate);
            }
            Console.WriteLine($"Общий урожай за первые шесть лет: {totalHarvest} центнеров");
        }
    }
}
