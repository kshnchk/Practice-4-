/*
3.9.«Странный муж». Некий мужчина отправляется на работу,
которая находится на расстоянии 1 км от дома. Дойдя до места
работы, он вдруг вспоминает, что перед уходом забыл поцеловать
жену, и поворачивает назад. Пройдя полпути, он меняет решение,
посчитав, что правильнее вернуться на работу. Пройдя 1/3 км по
направлению к работе, он вдруг осознает, что будет настоящим
подлецом, если так и не поцелует жену. На этот раз, прежде чем
изменить мнение, он проходит 1/4 км. Так он продолжает метаться,
после N-этапа, пройдя 1/N км, снова меняет решение. Определить:
а) на каком расстоянии от дома будет находиться мужчина после
100-го этапа (если допустить, что такое возможно);
б) какой общий путь он при этом пройдет
*/

namespace задание_3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("а)");
            double distanceFromHome = 0.0; 
            double workDistance = 1.0;
            double totalDistance = 0;
            for (int i = 1; i <= 100; i++)
            {
                double stepDistance = 1.0 / i;
                totalDistance += stepDistance;
                if (i % 2 == 0) 
                {
                    distanceFromHome += stepDistance;
                }
                else 
                {
                    distanceFromHome -= stepDistance;
                }

                if (distanceFromHome < 0) 
                {
                    distanceFromHome = 0;
                }
                if (distanceFromHome > workDistance) 
                {
                    distanceFromHome = workDistance;
                }
            }
            Console.WriteLine($"После 100 этапа мужчина будет находиться на расстоянии {distanceFromHome} км от дома");

            Console.WriteLine("б)");
            Console.WriteLine($"Общий пройденный путь: {totalDistance} км");

        }
    }
}
