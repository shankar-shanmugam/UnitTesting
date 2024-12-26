using System;
using System.Linq;

namespace UnittestingDemo
{
    public class NunitDemo
    {
        // Adds two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Subtracts the second integer from the first
        public int Sub(int a, int b)
        {
            return a - b;
        }

        // Checks if an integer is even
        public bool IsEven(int a)
        {
            return (a % 2 == 0);
        }

        // Multiplies two integers
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Divides 
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Denominator cannot be zero.");
            return a / b;
        }

        // Calculates the factorial 
        public int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Negative numbers are not allowed.");
            if (n == 0 || n == 1)
                return 1;
            return n * Factorial(n - 1);
        }

        // Checks if a string is a palindrome
        public bool IsPalindrome(string str)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str));
            var reversed = new string(str.ToCharArray().Reverse().ToArray());
            return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        // Finds the maximum number in an array
        public int FindMax(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");
            return numbers.Max();
        }

        // Calculates the power of a number
        public double Power(double baseNum, double exponent)
        {
            return Math.Pow(baseNum, exponent);
        }

        // Checks if a number is prime
        public bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
