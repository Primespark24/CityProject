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

        // GetPerimeter for Shape... Shape is generic so nothing should show but a error.
        public virtual void GetPerimeter()
        {
            Console.WriteLine("\n Error: Generic shapes don't contain valid area.");
        }

        public virtual void GetArea()
        {
            Console.WriteLine("\n Error: Generic shapes don't contain valid area.");
        }
    }
}