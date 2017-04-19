namespace Exceptions_Homework.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Utils
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null || arr.Length <= 0)
            {
                throw new ArgumentNullException("Array cannot be null or empty");
            }

            if (startIndex < 0 || startIndex >= arr.Length)
            {
                throw new ArgumentOutOfRangeException("Start index is out of boundries");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("Count cannot be negative");
            }

            if (startIndex + count > arr.Length)
            {
                throw new ArgumentOutOfRangeException("The sequence is out of the array boundries");
            }

            List<T> result = new List<T>();

            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("String cannot be null or empty");
            }

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("Count cannot exceed the string length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("Count cannot be negative");
            }

            StringBuilder result = new StringBuilder();

            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    Console.WriteLine($"{number} is not prime");
                    return false;
                }
            }

            Console.WriteLine($"{number} is prime.");
            return true;
        }
    }
}
