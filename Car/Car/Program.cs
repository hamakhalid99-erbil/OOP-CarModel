using System;
using System.Dynamic;

namespace Car
{
    class Program
    {

        static void Main(string[] args)
        {
            Class User = new Class();

            Console.WriteLine("Enter Your Car name: ");
            string CarName = Console.ReadLine();
            Console.WriteLine("Enter Car year: ");
            int CarYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the kilometers at the beginning: ");
            double StaringK = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the kilometers at the end: ");
            double EndingK = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of fuel spent in liters: ");
            double FuelC = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the trip length in hours: ");
            double TravelT = double.Parse(Console.ReadLine());

            User.Model = CarName;
            User.Year = CarYear;
            User.StartingKm = StaringK;
            User.EndingKm = EndingK;
            User.FuelConsumption = FuelC;
            User.TravelTime = TravelT;

            Console.WriteLine($"This is the trip length in km {User.GetTripLength()}");
            Console.WriteLine($"This is the average speed of the car {User.GetSpeed()}");
            Console.WriteLine($"This is the amount of liters per km {User.GetFuelEfficiency()}");
            User.ClassifyCar();
        }
    }
}
