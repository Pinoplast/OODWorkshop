using System;
using System.Collections.Generic;
using System.Text;

namespace OODWorkshop
{
    public abstract class Transport
    {
        private int speed;
        protected int position;
        protected readonly int height;
        public string Brand { get; }
        public string Model { get; }
        public string Id { get; set; }
        public int Speed { 
            get
            {
                return speed;
            }
            set 
            {
                if (value < 4)
                {
                    speed = value;
                }
            }
        }
        public ConsoleColor Color { get; set; }
 
        public Transport(string brand, string model, string id, int speed, int height, ConsoleColor color)
        {
            this.Brand = brand;
            this.Model = model;
            this.Id = id;
            this.height = height;
            this.Speed = speed;
            this.position = 0;
            this.Color = color;
        }

        public string GetDescription()
        {
            return String.Format("{0} {1}, number = {2}", Brand, Model, Id);
        }
    }

    public class Car : Transport
    {
        public Car(string brand, string model, string id, int speed, ConsoleColor color):base(brand, model, id, speed, 2, color)
        {
            
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription());
            ConsoleColor previousColor = Console.BackgroundColor;
            Console.BackgroundColor = Color;
            Console.CursorLeft = position + 1;
            Console.WriteLine("   ");
            Console.CursorLeft = position;
            Console.WriteLine("     ");
            Console.BackgroundColor = previousColor;        
        }
    }

    public class Bike : Transport
    {
        public Bike(string brand, string model, string id, int speed, ConsoleColor color):base(brand, model, id, speed, 3, color)
        {
        }
        public void Print()
        {
            Console.WriteLine(this.GetDescription());
            ConsoleColor previousColor = Console.BackgroundColor;
            Console.CursorLeft = position;
            Console.Write("   ");
            Console.BackgroundColor = Color;
            Console.WriteLine(" ");
            Console.CursorLeft = position;
            Console.WriteLine("   ");
            Console.CursorLeft = position;
            Console.Write(" ");
            Console.BackgroundColor = previousColor;        
            Console.Write(" ");
            Console.BackgroundColor = Color;
            Console.Write(" ");
            Console.BackgroundColor = previousColor;
        }
    }
}
