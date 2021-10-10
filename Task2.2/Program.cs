using System;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите длину комнаты в метрах");
                double RoomLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ширину комнаты в метрах");
                double RoomWidth = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту комнаты в метрах");
                double RoomHeight = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во окон");
                int Windows = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту окна");
                double WindowLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ширину окна");
                double WindowHeight = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во дверей");
                int Doors = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту двери");
                double DoorLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ширину двери");
                double DoorHeight = double.Parse(Console.ReadLine());

                double RoomSquare = (2 * RoomLength * RoomWidth) + (2 * RoomLength * RoomHeight) + (2 * RoomWidth * RoomHeight);
                double WindowSquare = (Windows * WindowLength * WindowHeight);
                double DoorSquare = (Doors * DoorHeight * DoorLength);

                double Room = RoomSquare - WindowSquare - DoorSquare;

                Console.WriteLine("Площадь поверхности под покраску равна {0}", Math.Round(Room, 2));

            }
            catch
            {
                Console.WriteLine("Недопустимый ввод");
            }
        }
    }
}
