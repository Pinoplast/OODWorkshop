using System;
using System.Collections.Generic;
using System.Text;

namespace OODWorkshop
{
    public abstract class Transport
    {
        public int position;
        public string brand;
        public string model;
        public string id;
        public int speed;
        public ConsoleColor color;
        private int size;

        public string GetDescription()
        {
            return String.Format("{0} {1}, number = {2}", brand, model, id);
        }
    }

    public class Car : Transport
    {
        public string type = nameof (Car);
        public void Print()
        {
            Console.WriteLine(this.GetDescription());
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
