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
            if (EqNumSides != 0)
            {
                try
                {
                    double apothem = (EqSideLen) / (2 * (Math.Tan(180 / EqNumSides)));
                    EqArea = .5 * apothem * EqNumSides;
                    return EqArea;
                }
                catch (Exception e)
                {
                    Console.WriteLine(" Error: {0}", e.Message);
                    return 0.0;
                }
            }
            else
            {
                Console.WriteLine(" Error: EqNumSides needs a number greater than 0");
                return 0.0;
            }
            
        }

        // Print properties for EqPolygon
        public override void PrintShape()
        {

            if (GetArea() != 0 && GetPerimeter() != 0)
            {
                Console.WriteLine("EqPolygon Perimeter: " + GetPerimeter());
                Console.WriteLine("EqPolygon Area: " + GetArea());
            }

            if ((GetArea() == 0 && GetPerimeter() == 0))
            {
                Console.WriteLine(" This shape hasn't been modified yet");
                Console.WriteLine(" Enter EqPolygon side Length: ");
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out double sideLen)) { EqSideLen = sideLen; break; }
                    else {Console.WriteLine(" Error: Try to input a int or a decimal"); }
                }
                Console.WriteLine(" Enter EqPolygon number of sides: ");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int numsides)) { EqNumSides = numsides; break; }
                    else { Console.WriteLine(" Error: Try to input a int"); }
                }
            }
        }
    }
}