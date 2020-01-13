using System;

namespace EX_01
{
    class Comparable
    {
        public interface IComparable
        {
            void CompareArea(Shape s1, Shape s2, string shape1, string shape2);
            void ComparePerimeter(Shape s1, Shape s2, string shape1, string shape2);
        }
    }
}
