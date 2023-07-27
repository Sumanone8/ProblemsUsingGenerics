using System;

namespace ProblemUsingGeneric
{
    internal class MaxNumberFinder
    {
        public static int FindMax(int a, int b, int c)
        {
            // Compare a with b and store the maximum
            int max = a.CompareTo(b) > 0 ? a : b;

            // Compare max with c and update if c is greater
            max = max.CompareTo(c) > 0 ? max : c;

            return max;
        }

        public static float FindMaxFloat(float a, float b, float c)
        {
            // Compare a with b and store the maximum
            float max = a > b ? a : b;

            // Compare max with c and update if c is greater
            max = max > c ? max : c;

            return max;
        }

        public static string FindMaxString(string a, string b, string c)
        {
            // Compare a with b and store the maximum
            string max = a.CompareTo(b) > 0 ? a : b;

            // Compare max with c and update if c is greater
            max = max.CompareTo(c) > 0 ? max : c;

            return max;
        }

        public static void RunMaxNumberFinder()
        {
            // Test case 1: Max number at the 1st position
            int test1Max = FindMax(10, 5, 7);
            Console.WriteLine("Test case 1 (Integers): " + test1Max); // Output: 10

            // Test case 2: Max number at the 2nd position
            int test2Max = FindMax(3, 8, 2);
            Console.WriteLine("Test case 2 (Integers): " + test2Max); // Output: 8

            // Test case 3: Max number at the 3rd position
            int test3Max = FindMax(4, 6, 12);
            Console.WriteLine("Test case 3 (Integers): " + test3Max); // Output: 12
        }

        public static void RunMaxNumberFinderFloat()
        {
            // Test case 1: Max number at the 1st position
            float test1Max = FindMaxFloat(10.5f, 5.2f, 7.8f);
            Console.WriteLine("Test case 1 (Floats): " + test1Max); // Output: 10.5

            // Test case 2: Max number at the 2nd position
            float test2Max = FindMaxFloat(3.1f, 8.7f, 2.6f);
            Console.WriteLine("Test case 2 (Floats): " + test2Max); // Output: 8.7

            // Test case 3: Max number at the 3rd position
            float test3Max = FindMaxFloat(4.3f, 6.9f, 12.2f);
            Console.WriteLine("Test case 3 (Floats): " + test3Max); // Output: 12.2
        }

        public static void RunMaxNumberFinderString()
        {
            // Test case 1: Max string at the 1st position
            string test1Max = FindMaxString("Apple", "Peach", "Banana");
            Console.WriteLine("Test case 1 (Strings): " + test1Max); // Output: "Peach"

            // Test case 2: Max string at the 2nd position
            string test2Max = FindMaxString("Orange", "Grapes", "Kiwi");
            Console.WriteLine("Test case 2 (Strings): " + test2Max); // Output: "Orange"

            // Test case 3: Max string at the 3rd position
            string test3Max = FindMaxString("Dog", "Cat", "Elephant");
            Console.WriteLine("Test case 3 (Strings): " + test3Max); // Output: "Elephant"
        }
    }
}