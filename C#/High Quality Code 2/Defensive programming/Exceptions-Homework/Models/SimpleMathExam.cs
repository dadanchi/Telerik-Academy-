namespace Exceptions_Homework.Models
{
    using System;

    using Abstract_Classes;

    public class SimpleMathExam : Exam
    {
        private const int MaxProblemsCount = 10;

        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Problems solved cannot be a negative number");
                }

                if (value > MaxProblemsCount)
                {
                    throw new ArgumentOutOfRangeException($"The count of problems cannot exceed {MaxProblemsCount}");
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult CalculateScore()
        {
            if (this.ProblemsSolved < 3)
            {
                return new ExamResult(2, 2, 6, "Bad result: almost nothing done.");
            }
            else if (this.ProblemsSolved > 3 && this.ProblemsSolved < 7)
            {
                return new ExamResult(4, 2, 6, "Average result: some of the tasks are done.");
            }
            else
            {
                return new ExamResult(6, 2, 6, "Excellent result: most of the tasks are done.");
            }
        }
    }
}