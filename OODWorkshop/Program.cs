using System;

namespace OODWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Zazlesla", "First model", "LAT433", 2, ConsoleColor.Blue);
            car.Print();
        }
    }
}
