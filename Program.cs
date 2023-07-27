using System;

namespace ProblemUsingGeneric
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
                    MaxNumberFinder.RunMaxNumberFinder();
                    break;
                case 2:
                    MaxNumberFinder.RunMaxNumberFinderFloat();
                    break;
                case 3:
                    MaxNumberFinder.RunMaxNumberFinderString();
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid Index No.");
                    break;
            }
            Console.ReadLine();
        }
    }
}