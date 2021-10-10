using System;

namespace Task1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите любое значение");
            string value = Console.ReadLine();
            string name = NameOfValue(value);
            Console.WriteLine("Введенное значение - " + name);

        }
        static string NameOfValue(string value)
        {
            if (bool.TryParse(value, out _))
            {
                return "bool";
            }
            if (int.TryParse(value, out _))
            {
                return "int";
            }
            if (double.TryParse(value, out _))
            {
                return "double";
            }

            else return "string";
        }
    }
}
