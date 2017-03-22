namespace LoopRefactoring
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            const int ExpectedValue = 6;
            int[] numbers =
                {
                    3,
                    2,
                    5,
                    7,
                    6,
                    123
                };

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentValue = numbers[i];

                Console.WriteLine(currentValue);

                if (i % 2 == 0 && currentValue == ExpectedValue)
                {
                    Console.WriteLine($"Value Found at index {i}");
                    break;
                }
            }
        }
    }
}
