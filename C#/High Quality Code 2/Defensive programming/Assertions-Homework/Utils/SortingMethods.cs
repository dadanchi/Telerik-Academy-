namespace Assertions_Homework.Utils
{
    using System;
    using System.Diagnostics;

    public static class SortingMethods
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            bool arrayIsNull = arr == null || arr.Length <= 0;
            Debug.Assert(!arrayIsNull, "Array cannot be empty");

            bool arrayContainsOnlyOneElement = arr.Length == 1;
            Debug.Assert(!arrayContainsOnlyOneElement, "Cannot sort array with one element");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);

                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            bool arrayIsNull = arr == null || arr.Length <= 0;
            Debug.Assert(!arrayIsNull, "Array cannot be empty");

            bool isValidStartIndex = startIndex >= 0 && startIndex < arr.Length;
            Debug.Assert(isValidStartIndex, "Start index is out of range");

            bool isValidEndIndex = endIndex > 0 && endIndex < arr.Length;
            Debug.Assert(isValidEndIndex, "End index is out of range");

            bool startIndexIsBeforeEndIndex = startIndex <= endIndex;
            Debug.Assert(startIndexIsBeforeEndIndex, "Start index cannot be higher than end index");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
