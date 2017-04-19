namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;

    using Abstract_Classes;
    using Exceptions_Homework.Models;
    using Exceptions_Homework.Utils;

    public class StartUp
    {
        public static void Main()
        {
            var substr = Utils.Utils.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Utils.Utils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Utils.Utils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = Utils.Utils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            try
            {
                Console.WriteLine(Utils.Utils.ExtractEnding("I love C#", 2));
                Console.WriteLine(Utils.Utils.ExtractEnding("Nakov", 4));
                Console.WriteLine(Utils.Utils.ExtractEnding("beer", 4));
                Console.WriteLine(Utils.Utils.ExtractEnding("Hi", 100));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Utils.Utils.CheckPrime(23);
            Utils.Utils.CheckPrime(33);

            var peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}