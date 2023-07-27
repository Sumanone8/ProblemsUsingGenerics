using System;

namespace ProblemsUsingGenerics
{
    internal static class Converter
    {
        public static T ConvertToT<T>(object value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}