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

        // GET SET TriArea
        public double TriArea
        {
            get;
            set;
        }

        // Get Set TriPerimeter
        public double TriPerimeter
        {
            get;
            set;
        }

        // default Constructor
        public Triangle()
        {
            TriSideLen = 0;
        }
        

        // Constructor
        public Triangle(double triSideLen)
        {
            this.TriSideLen = triSideLen;
        }

        // Get perimeter for Triangle
        public override double GetPerimeter()
        {
            TriPerimeter = TriSideLen * 3;
            return TriPerimeter;
        }

        // Area for Triangle
        public override double GetArea()
        {
            try
            {
                TriArea = ((Math.Sqrt(3)/(4)) * (TriSideLen * TriSideLen));
                return TriArea;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
                return 0.0;
            }
        }

        // Printed Triangle Properties
        public override void PrintShape()
        {
            Console.WriteLine("Triangle Perimeter: " + GetPerimeter());
            Console.WriteLine("Triangle Area: " + GetArea());

            // Credit https://www.programiz.com/c-programming/examples/pyramid-pattern

            if ((GetArea() == 0 && GetPerimeter() == 0))
            {
                Console.WriteLine("This shape hasn't been modified yet");
                Console.WriteLine("Enter Triangle Side Length: ");
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out double TriLength))
                    {
                        TriSideLen = TriLength;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Try to input a int or a decimal");
                    }
                }
            }
        }
    }
}