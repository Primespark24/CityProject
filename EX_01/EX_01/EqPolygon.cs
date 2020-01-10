using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_01
{
    public class EqPolygon : Shape
    {

        // Set Get methods
        public double SideLen
        {
            get;
            set;
        }

        // Set Get Methods
        public int NumSides
        {
            get;
            set;
        }

        // GetPerimeter() for EqPolygon
        public override void GetPerimeter()
        {
            Console.WriteLine("\n How many sides of this polygon?");
            NumSides = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n What is the length of each side?");
            SideLen = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" EqPolygon Perimeter: {0}", SideLen * NumSides);
        }

        // Area for EqPolygon
        public override void GetArea()
        {
            try
            {
                double apothem = (SideLen) / (2 * (Math.Tan(180 / NumSides)));
                double area = .5 * apothem * NumSides;
                Console.WriteLine(" EqPolygon Area: {0}", area);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }
    }
}