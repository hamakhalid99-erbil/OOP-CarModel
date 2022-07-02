using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Class
    {
        public string Model;
        public int Year;
        public double StartingKm;
        public double EndingKm;
        public double FuelConsumption;
        public double TravelTime;

        public double GetTripLength()
        {
            double TripLength = EndingKm - StartingKm;
            return TripLength;
        }
        public double GetSpeed()
        {
            double Speed = GetTripLength() / TravelTime;
            return Speed;
        }
        public double GetFuelEfficiency()
        {
            double FuelEfficiency = GetTripLength() / (FuelConsumption / 100);
            return FuelEfficiency;
        }
        public void ClassifyCar()
        {
            double age = DateTime.Now.Year - Year;
            if (age <= 1)
            {
                Console.WriteLine("New Car, Enjoy it");
            }
            else if (age <= 3)
            {
                Console.WriteLine("Semi-Used Car, How is it going");
            }
            else if (age <= 5)
            {
                Console.WriteLine("Used-Car, Time for looking a new Car");
            }
            else if (age > 5)
            {
                Console.WriteLine("Old Car, Please Change it");
            }
        }
    }
}
