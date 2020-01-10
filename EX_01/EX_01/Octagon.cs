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

        // Set Get Perimeter
        public double OctPerimeter
        {
            get;
            set;
        }

        // Set Get Area
        public double OctArea
        {
            get; 
            set;
        }

        //Default Constructor
        public Octagon()
        {
            OctSideLen = 0;
        }

        // Constructor
        public Octagon(double OctSideLen)
        {
            this.OctSideLen = OctSideLen;
        }

        // Perimeter for Octagon
        public override double GetPerimeter()
        {
            
            OctPerimeter = (OctSideLen * 8);
            return OctPerimeter;
        }

        // Area for Octagon
        public override double GetArea()
        {
            try
            {
                OctArea = 2 * (1 + Math.Sqrt(2) * (OctSideLen * OctSideLen));
                return OctArea;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
                return 0.0;
            }
        }
    }
}