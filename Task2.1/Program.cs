using System;

namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость с НДС");
            decimal priceNDS;
            string value = Console.ReadLine();
            if (TryParsePrice(value, out priceNDS))
            {
                decimal price = (priceNDS * 100) / 120;
                decimal NDS = priceNDS - price;
                Console.WriteLine("Cтоимость без НДС равна {0}", price);
                Console.WriteLine("Сумма НДС в чеке {0}", Math.Round(NDS, 2));
                if ((NDS - Math.Truncate(NDS)) >= 0.5m)
                {
                    Console.WriteLine("Сумма НДС для деклорации {0}", Math.Ceiling(NDS));
                }
                else
                {
                    Console.WriteLine("Сумма НДС для деклорации {0}", Math.Floor(NDS));
                }

            }
            else
            {
                Console.WriteLine("Ошибка значения");
            }

        }
        static bool TryParsePrice(string value, out decimal priceNDS)
        {
            return decimal.TryParse(value, out priceNDS);
        }
    }
}
