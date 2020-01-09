using System;

namespace EX_01
{
    public class Octagon : EqPolygon
    {

        // Methods for get and set for OctSideLen
        public double OctSideLen
        {
            get;
            set;
        }

        // Perimeter for Octagon
        public override void GetPerimeter()
        {
            Console.WriteLine("\n Octagon: Enter side length");
            OctSideLen = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Octagon Perimeter: {0}" , OctSideLen * 8);
        }
    }
}