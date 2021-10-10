using System;

namespace Task1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое значение");
            int count = 0;
            double min = 1000;
            double max = -1000;
            double sum = 0;
            double avg = 0.0;
            while (true)
            {
                string value = Console.ReadLine();
                double number;
                if (TryParseNumber(value, out number))
                {
                    count++;
                    if (number <= min)
                    {
                        min = number;
                    }
                    if (number >= max)
                    {
                        max = number;
                    }
                    sum = sum + number;
                }
                else
                {
                    Console.WriteLine("Ошибка значения");
                    break;
                }
            }
            avg = sum / count;
            Console.WriteLine("Ответ:" + "\n" + "Всего значений " + count + "\n" + "Минимальное " + min + "\n" + "Максимальное " + max + "\n" + "Сумма " + sum + "\n" + "Среднее " + avg);
        }

        static bool TryParseNumber(string value, out double number)
        {
            return double.TryParse(value, out number) && number >= -1000 && number <= 1000;
        }
    }
}
