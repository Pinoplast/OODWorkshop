using System;

namespace OODWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport transport = new Car("Zazlesla", "First model", "LAT433", 2, ConsoleColor.Blue);
            transport.Print();
        }
    }
}
