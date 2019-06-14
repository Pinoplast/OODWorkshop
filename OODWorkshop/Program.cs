using System;

namespace OODWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            bike.brand = "Zazlesla";
            bike.model = "First model";
            bike.id = "LT341";
            bike.speed = 100;
            bike.position = 4;
            bike.color = ConsoleColor.Blue;
            bike.Print();
        }
    }
}
