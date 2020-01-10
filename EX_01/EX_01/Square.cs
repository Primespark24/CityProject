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
    }
}