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
    }
}