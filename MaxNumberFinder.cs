using System;

namespace ProblemsUsingGenerics
{
    internal static class MaxNumberFinder
    {
        public static T FindMax<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;
            if (b.CompareTo(max) > 0)
                max = b;

            if (c.CompareTo(max) > 0)
                max = c;

            return max;
        }
    }
}
