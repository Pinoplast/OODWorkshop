using System;

namespace OODWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.brand = "Zazlesla";
            car.model = "First model";
            car.id = "LT341";
            car.speed = 100;
            car.position = 4;
            car.color = ConsoleColor.Blue;
            car.Print();
        }
    }
}
