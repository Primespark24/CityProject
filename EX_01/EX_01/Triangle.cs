using System;

namespace EX_01
{
    public class Triangle : EqPolygon
    {

        // Method Set and Get
        public double TriSideLen
        {
            get;
            set;
        }

        // Get perimeter for Triangle
        public override void GetPerimeter()
        {
            Console.WriteLine("\n Triangle: Enter side length");
            TriSideLen = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Triangle Perimeter: {0}", TriSideLen * 3);

        }
    }
}