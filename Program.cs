using System;
using static System.Console;
using CarSimulator.Domain;

namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldNotExit = true;

            Car[] carList = new Car[10];

            ushort carListCurrentIndexPosition = 0;

            while (shouldNotExit)
            {
                WriteLine("1. Add car");
                WriteLine("2. List cars");
                WriteLine("3. Simulate speed");
                WriteLine("4. Exit");

                ConsoleKeyInfo KeyPressed = ReadKey(true);

                Clear();

                switch (KeyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        Write("Brand: ");

                        string brand = ReadLine();

                        Write("Model: ");

                        string model = ReadLine();

                        Car myCar = new Car(brand, model);

                        carList[carListCurrentIndexPosition++] = myCar;

                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        break;
                }
            }
        }
    }
}
