using System;

namespace EX_01
{
    public class Circle : Shape
    {

        // Get Set methods for radius
        public double Radius
        {
            get;
            set;
        }

        // Set get of Circle Perimeter
        public double Cperimeter 
        { 
            get; 
            set;
        }

        //  Set Get of Circle Area
        public double Carea
        {
            get;
            set;
        }

        // Default Constructor
        public Circle()
        {
            Radius = 0;
        }

        // Constructor
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        // Perimeter questions for circle
        public override double GetPerimeter()
        {

           Cperimeter = (3.141595267898 * Radius * 2);
           return Cperimeter;
        }

        // Area for circle
        public override double GetArea()
        {
           Carea = (3.141595267898 * Radius * Radius);
           return Carea;
        }
    }
}