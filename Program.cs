using System;

namespace ProblemsUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fellow Learners!\nWelcome to Basic Core Programs.\nEnter the index no. of the program you want to run.");
            Console.WriteLine("1. Find the maximum no from 3 (Integers).\n2. Find the maximum number from 3 (Floats).\n3. Find the maximum string from 3.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    RunMaxNumberFinder<int>();
                    break;
                case 2:
                    RunMaxNumberFinder<float>();
                    break;
                case 3:
                    RunMaxNumberFinder<string>();
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid Index No.");
                    break;
            }
            Console.ReadLine();
        }

        public static void RunMaxNumberFinder<T>() where T : IComparable<T>
        {
            Console.WriteLine($"Running MaxNumberFinder for type {typeof(T).Name}");

            T test1Max = MaxNumberFinder.FindMax<T>(Converter.ConvertToT<T>(10), Converter.ConvertToT<T>(5), Converter.ConvertToT<T>(7));
            Console.WriteLine("Test case 1: " + test1Max); // Output: 10

            T test2Max = MaxNumberFinder.FindMax<T>(Converter.ConvertToT<T>(3), Converter.ConvertToT<T>(8), Converter.ConvertToT<T>(2));
            Console.WriteLine("Test case 2: " + test2Max); // Output: 8

            T test3Max = MaxNumberFinder.FindMax<T>(Converter.ConvertToT<T>(4), Converter.ConvertToT<T>(6), Converter.ConvertToT<T>(12));
            Console.WriteLine("Test case 3: " + test3Max); // Output: 12
        }
    }
}

