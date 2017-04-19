namespace Assertions_Homework.Utils
{
    using System;
    using System.Diagnostics;

    public static class SearchMethods
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            bool arrayIsNull = arr == null || arr.Length <= 0;
            Debug.Assert(!arrayIsNull, "Array cannot be empty");

            int result = BinarySearch(arr, value, 0, arr.Length - 1);

            return result;
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            bool arrayIsNull = arr == null || arr.Length <= 0;
            Debug.Assert(!arrayIsNull, "Array cannot be empty");

            bool isValidStartIndex = startIndex >= 0 && startIndex < arr.Length;
            Debug.Assert(isValidStartIndex, "Start index is out of range");

            bool isValidEndIndex = endIndex > 0 && endIndex < arr.Length;
            Debug.Assert(isValidEndIndex, "End index is out of range");

            bool startIndexIsBeforeEndIndex = startIndex < endIndex;
            Debug.Assert(startIndexIsBeforeEndIndex, "Start index cannot be higher than end index");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the left half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
