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

        // Area for Octagon
        public override void GetArea()
        {
            try
            {
                double area = 2 * (1 + Math.Sqrt(2) * (OctSideLen * OctSideLen));
                Console.WriteLine(" Octagon Area: {0}", area);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }
    }
}