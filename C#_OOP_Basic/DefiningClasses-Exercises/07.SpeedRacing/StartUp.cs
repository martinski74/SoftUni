using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            var cars = new List<Car>();

            var carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var model = carInfo[0];
                var fuel = decimal.Parse(carInfo[1]);
                var fuelCost = decimal.Parse(carInfo[2]);

                cars.Add(new Car(model,fuel,fuelCost));

            }

            var command = Console.ReadLine();
            while (command != "End")
            {
                var tokens = command.Split();
                var model = tokens[1];
                var distance = decimal.Parse(tokens[2]);

                var currentCar = cars.FirstOrDefault(c => c.Model == model);

                if (!Car.CanDrive(currentCar,distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                command = Console.ReadLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel :f2} {(int)car.TraveledDistance}");
            }
        }
    }
}
