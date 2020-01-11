using EX_01;
using System;


namespace EX_01
{
    class Class1 : Comparable.IComparable
    {
        public void CompareArea(Shape s1, Shape s2);
        {
            if (s1.GetArea() < s2.GetArea())
            {
                Console.WriteLine("Shape1 has a greater area than shape2 by :  {0}" , s1.GetArea() - s2.GetArea());
            }
            else
            {
                Console.WriteLine("Shape2 has a greater area than shape1 by : " + (shape2.Area - shape1.Area));
            }
        }
    }

    public void ComparePerimeter(Shape s1, Shape s2)
    {
        if (s1.GetPerimeter() < s2.GetPerimeter())
        {
            Console.WriteLine("Shape1 has a greater perimeter than shape2 by : " + (shape1.Area - shape2.Perimeter));
        }
        else
        {
            Console.WriteLine("Shape2 has a greater perimeter than shape1 by : " + (shape2.Perimeter - shape1.Perimeter));
        }
    }
}
