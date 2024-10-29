using System;

//There are two key features of a static class.
//First, no object of a static class can be created.
//Second, a static class must contain only static members.

namespace StaticClassExample
{
    public static class MathUtilities
    {
        // Static method for addition
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Static method for subtraction
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        // Static method to calculate the square of a number
        public static int Square(int number)
        {
            return number * number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using static methods from MathUtilities class.
            int sum = MathUtilities.Add(10, 5);
            int difference = MathUtilities.Subtract(10, 5);
            int square = MathUtilities.Square(4);

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Square: " + square);
        }
    }
}
