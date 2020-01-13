using System;


namespace EX_01
{
    public class Shape
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
        public virtual double GetPerimeter()
        {
            return 0;
        }

        // Get Area
        public virtual double GetArea()
        {
            return 0;
        }

        public virtual void PrintShape()
        {
            Console.WriteLine("Shape Perimeter: Undefined b/c generic shape");
            Console.WriteLine("Shape Area: Undefined b/c generic shape");
        }
    }
}