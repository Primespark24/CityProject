using System;

namespace EX_01
{
    public class EqPolygon : Shape
    {

        // Set Get methods
        public double EqSideLen
        {
            get;
            set;
        }

        // Set Get Methods
        public int EqNumSides
        {
            get;
            set;
        }

        // Set Get EqArea Method
        public double EqArea
        {
            get;
            set;
        }

        // Set Get EqPerimeter method
        public double EqPerimeter
        {
            get;
            set;
        }

        // Default Constructor
        public EqPolygon()
        {
            EqNumSides = 0;
            EqSideLen = 0;
        }

        // Constructor
        public EqPolygon(double eqSideLen, int eqNumSides)
        {
            this.EqSideLen = eqSideLen;
            this.EqNumSides = eqNumSides;
        }

        // GetPerimeter() for EqPolygon
        public override double GetPerimeter()
        {
            EqPerimeter = EqSideLen * EqNumSides;
            return EqPerimeter;
        }

        // Area for EqPolygon
        public override double GetArea()
        {
            try
            {
                double apothem = (EqSideLen) / (2 * (Math.Tan(180 / EqNumSides)));
                EqArea = .5 * apothem * EqNumSides;
                return EqArea;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
                return 0.0;
            }
        }
    }
}