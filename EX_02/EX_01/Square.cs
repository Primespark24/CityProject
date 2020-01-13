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

        // Set Get Area
        public double SqArea
        {
            get;
            set;
        }

        // Set Get Perimeter
        public double SqPerimeter
        {
            get;
            set;
        }

        // Default Constructor
        public Square()
        {
            SqSideLen = 0;
        }

        // Constructor
        public Square(double SqSideLen)
        {
            this.SqSideLen = SqSideLen;
        }


        // Get Perimeter for Square
        public override double GetPerimeter()
        {
            SqPerimeter = (SqSideLen * 4);
            return SqPerimeter;
        }

        // Area for Square
        public override double GetArea()
        {
            try
            {
                SqArea = SqSideLen * SqSideLen;
                return SqArea;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
                return 0.0;
            }
        }

        // Print properties for Square
        public override void PrintShape()
        {
            Console.WriteLine("Square Perimeter: " + GetPerimeter());
            Console.WriteLine("Square Area: " + GetArea());
            if ((GetArea() == 0 && GetPerimeter() == 0))
            {
                Console.WriteLine("This shape hasn't been modified yet");
                Console.WriteLine("Enter Square Side Length: ");
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out double sqLength)) { SqSideLen = sqLength; break; }
                    else Console.WriteLine("Error: Try to input a int or a decimal");
                }
            }
        }
    }
}