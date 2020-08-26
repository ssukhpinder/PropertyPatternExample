using System;

namespace PropertyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var car = new Car();
            var taxi = new Taxi();
            var bus = new Bus();
            var truck = new DeliveryTruck();


            Console.WriteLine($"The toll for a car is {TollFare(car)}");
            Console.WriteLine($"The toll for a taxi is {TollFare(taxi)}");
            Console.WriteLine($"The toll for a bus is {TollFare(bus)}");
            Console.WriteLine($"The toll for a truck is {TollFare(truck)}");


            Console.WriteLine("=========================================");
            Console.WriteLine("=========================================");

            var car1 = new Car{ PassengerCount=2};
            var taxi1 = new Taxi { Fare = 0 };
            var bus1 = new Bus { Capacity = 100, RidersCount = 30 };
            var truck1 = new DeliveryTruck { Weight = 30000 };

            Console.WriteLine($"The toll for a car is {OccupancyTypeTollFare(car1)}");
            Console.WriteLine($"The toll for a taxi is {OccupancyTypeTollFare(taxi1)}");
            Console.WriteLine($"The toll for a bus is {OccupancyTypeTollFare(bus1)}");
            Console.WriteLine($"The toll for a truck is {OccupancyTypeTollFare(truck1)}");
        }

        public static int TollFare(Object vehicleType) => vehicleType switch
        {
            Car c => 100,
            DeliveryTruck d => 200,
            Bus b => 150,
            Taxi t => 120,
            null => 0,
            { } => 0
        };

        public static int OccupancyTypeTollFare(Object vehicleType) => vehicleType switch
        {
            Car { PassengerCount: 0 } => 100 + 10,
            Car { PassengerCount: 1 } => 100,
            Car { PassengerCount: 2 } => 100 - 10,
            Car c => 100 - 20,

            Taxi {Fare:0 }=>100+10,
            Taxi { Fare: 1 } => 100,
            Taxi { Fare: 2 } => 100 - 10,
            Taxi t => 100 - 20,

            Bus b when ((double)b.RidersCount / (double)b.Capacity) < 0.50 => 150 + 30,
            Bus b when ((double)b.RidersCount / (double)b.Capacity) > 0.90 => 150 - 40,
            Bus b => 150,

            DeliveryTruck t when (t.Weight > 5000) => 200 + 100,
            DeliveryTruck t when (t.Weight < 3000) => 200 - 20,
            DeliveryTruck t => 200,

            null => 0,
            { } => 0,
        };
    }
}
