using System;

namespace Task2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetDate();
            Console.WriteLine("\nВведите количество минут до ожидаемого события");
            string value = Console.ReadLine();
            int Minutes;
            if (NumberOfMin(value, out Minutes))
            {

                StartEvent(Minutes);
                GetResult(Minutes);

            }
            else
            {
                Console.WriteLine("Ошбика введенного значения");
            }

        }
        static bool NumberOfMin(string value, out int Minutes)
        {
            return int.TryParse(value, out Minutes);
        }

        static void StartEvent(int Minutes)
        {
            if (Minutes <= 0)
            {
                Console.WriteLine("Событие уже началось!");
            }
        }

        static void GetResult(int Minutes)
        {
            double Day = Math.Truncate(Minutes / 1440d);
            double Hour = Math.Truncate((Minutes - (1440 * Day)) / 60);
            double Minute = Math.Truncate((Minutes - (1440 * Day)) - (60 * Hour));
            PrintResult(Day, Hour, Minute);
        }

        static void PrintResult(double Day, double Hour, double Minute)
        {
            Console.WriteLine("До события {0} дн. {1} ч. {2} мин.", Day, Hour, Minute);
        }
        static void GetDate()
        {
            Console.WriteLine("Введите дату и время в формате dd.mm.yyy");
            DateTime Date = DateTime.Parse(Console.ReadLine());
            DateTime DateNow = DateTime.Now;
            System.TimeSpan diff = (Date - DateNow);
            int hour = diff.Hours;
            int min = diff.Minutes;
            int day = diff.Days;
            int minute = day * 1440 + hour * 60 + min;
            Console.WriteLine("До введенной даты осталось {0} мин.", minute);

        }
    }
}
