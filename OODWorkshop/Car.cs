using System;
using System.Collections.Generic;
using System.Text;

namespace OODWorkshop
{
    public class Car
    {
        public int position;
        public string brand;
        public string model;
        public string id;
        public int speed;
        public ConsoleColor color;

        public void Print()
        {
            Console.WriteLine(String.Format("{0} {1}, number = {2}", brand, model, id));
            ConsoleColor previousColor = Console.BackgroundColor;
            Console.BackgroundColor = color;
            Console.CursorLeft = position + 1;
            Console.WriteLine("   ");
            Console.CursorLeft = position;
            Console.WriteLine("     ");
            Console.BackgroundColor = previousColor;
        }
    }
}
