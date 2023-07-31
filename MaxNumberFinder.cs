using System;

namespace ProblemsUsingGenerics
{
    internal class MaxNumberFinder<T> where T : IComparable<T>
    {
        private T[] values;

        public MaxNumberFinder(params T[] values)
        {
            this.values = values;
        }

        public T TestMaximum()
        {
            return FindMax(values);
        }

        private static T FindMax(params T[] values)
        {
            T max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                    max = values[i];
            }
            return max;
        }
    }
}