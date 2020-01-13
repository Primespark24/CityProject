using EO.Internal;
using EX_01;
using System;


namespace EX_01
{
    class compare : Comparable.IComparable
    {
        public void CompareArea(Shape s1, Shape s2, string shape1, string shape2)
        {


            if (s1.GetArea() > s2.GetArea())
            {
               Console.WriteLine("\n" + shape1 + " has a greater area than " + shape2 + " by :  {0}", Math.Abs(s1.GetArea() - s2.GetArea()));
            }
            else
            {
               Console.WriteLine("\n" + shape2 + " has a greater area than " + shape1 + " by : " + Math.Abs(s2.GetArea() - s1.GetArea()));
            }
        }


        public void ComparePerimeter(Shape s1, Shape s2, string shape1, string shape2)
        {
            if (s1.GetPerimeter() > s2.GetPerimeter())
            {
              Console.WriteLine("\n" + shape1 + " has a greater perimeter than " + shape2 + " by : " + Math.Abs(s1.GetArea() - s2.GetPerimeter()));
            }
            else
            {
              Console.WriteLine("\n" + shape2 + " has a greater perimeter than " + shape1 + " by : " + Math.Abs(s2.GetPerimeter() - s1.GetArea()));
            }
        }
    }
}
