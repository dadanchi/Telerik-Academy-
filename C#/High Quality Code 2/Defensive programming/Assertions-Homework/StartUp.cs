namespace Assertions_Homework
{
    using System;
    using Assertions_Homework.Utils;

    public class StartUp
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SortingMethods.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            // Test sorting empty array
            // SelectionSort(new int[0]);

            // Test sorting single element array  
            // SelectionSort(new int[1]);
              
            var currentValue = SearchMethods.BinarySearch(arr, -1000);
            Console.WriteLine(currentValue);
            currentValue = SearchMethods.BinarySearch(arr, 0);
            Console.WriteLine(currentValue);
            currentValue = SearchMethods.BinarySearch(arr, 17);
            Console.WriteLine(currentValue);
            currentValue = SearchMethods.BinarySearch(arr, 10);
            Console.WriteLine(currentValue);
            currentValue = SearchMethods.BinarySearch(arr, 1000);
            Console.WriteLine(currentValue);
        }
    }
}
