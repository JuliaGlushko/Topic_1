using System;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число от -1 000 000 до 1 000 000");
            string input = Console.ReadLine();
            long a;
            if (TryParseNumber(input, out a))
            {
                long b = a * a;
                Console.WriteLine("Квадрат числа " + a + " равен " + b);
            }
            else
            {
                Console.WriteLine("Ошибка введенного значения");
            }

        }
        static bool TryParseNumber(string number, out long a)
        {
            return long.TryParse(number, out a) && a >= -1_000_000 && a <= 1_000_000;
        }
    }
}
