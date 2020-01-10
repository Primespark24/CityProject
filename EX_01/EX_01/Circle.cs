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

        // Perimeter questions for circle
        public override void GetPerimeter()
        {

            Console.WriteLine("Enter radius for circle");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Circle Perimeter: {0}", 3.141595267898 * Radius * 2);
        }

        // Area for circle
        public override void GetArea()
        {
            Console.WriteLine(" Circle Area: {0}", 3.141595267898 * Radius * Radius);
        }
    }
}