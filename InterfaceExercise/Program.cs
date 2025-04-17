using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car()
            {
                Name = "Toyota",
                YearFounded = 1950,
                Doors = 2,
                HeatedSeats = false,
                CupholderCount = 10,
                HasTrunk = false,
                Transmission = "Automatic",
                BodyStyle = "Hatchback",
            };

            var suvOne = new SUV()
            {
                Name = "Dodge",
                YearFounded = 1950,
                Doors = 4,
                HeatedSeats = true,
                CupholderCount = 3,
                Transmission = "Automatic",
                ThirdRowSeating = true,
                LuggageRack = false
            };

            var truckOne = new Truck()
            {
                Name = "Nissan",
                YearFounded = 1950,
                Doors = 4,
                HeatedSeats = false,
                CupholderCount = 2,
                Transmission = "Automatic",
                FourWheelDrive = true,
                BedLengthFeet = 5
            };

            List<IVehicleExtended> myVehicles = [carOne, suvOne, truckOne];

            foreach (IVehicleExtended vehicle in myVehicles)
            {
                vehicle.DisplayDetails();
                Console.WriteLine();
            }
        }
    }
}
