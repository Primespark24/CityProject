using System;

namespace EX_01
{
    public class Square : EqPolygon
    {

        // Method Get and Set for sqSideLen
        public double SqSideLen
        {
            get;
            set;
        }

        // Get Perimeter for Square
        public override void GetPerimeter()
        {
            Console.WriteLine("\n Square: Enter side length");
            SqSideLen = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Square Perimeter: {0}", SqSideLen * 4);
        }
    }
}