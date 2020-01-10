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
        public Shape(string Color)
        {
            this.Color = Color;
        }

        // GetPerimeter for Shape... Shape is generic so nothing should show but a error.
        public virtual double GetPerimeter()
        {
            Console.WriteLine("\n Error: Generic shapes don't contain valid area.");
            return 0.0;
        }

        // Get Area
        public virtual double GetArea()
        {
            Console.WriteLine("\n Error: Generic shapes don't contain valid area.");
            return 0.0;
        }
    }
}