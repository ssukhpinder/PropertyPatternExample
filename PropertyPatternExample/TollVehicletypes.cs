using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyPatternExample
{
    public class Car
    {
        public int PassengerCount { get; set; }
    }
    public class DeliveryTruck
    {
        public int Weight { get; set; }
    }
    public class Taxi
    {
        public int Fare { get; set; }
    }

    public class Bus
    {
        public int Capacity { get; set; }
        public int RidersCount { get; set; }
    }
}
