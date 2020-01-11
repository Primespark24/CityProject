using System;


namespace EX_01
{
    public abstract class Shape
    {
        
        // Method Set and Get
        public string Color
        {
            get;
            set;
        }

        // Default Constructor
        public Shape()
        {
            Color = "Blue";
        }

        // Constructor
        public Shape(string color)
        {
            Color = color;
        }

        // GetPerimeter for Shape... Shape is generic so nothing should show but a error.
        public abstract double GetPerimeter();

        // Get Area
        public abstract double GetArea();

        public virtual void PrintShape()
        {
            Console.WriteLine("Shape Perimeter: " + GetPerimeter());
            Console.WriteLine("Shape Area: " + GetArea());
        }
    }
}