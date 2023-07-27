using System;

namespace ProblemsUsingGenerics
{
    internal class MaxNumberFinder<T> where T : IComparable<T>
    {
        private T a;
        private T b;
        private T c;

        public MaxNumberFinder(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public T TestMaximum()
        {
            return MaxNumberFinder<T>.FindMax(a, b, c);
        }

        private static T FindMax(T a, T b, T c)
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
