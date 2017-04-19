namespace Exceptions_Homework.Models
{
    using System;

    using Exceptions_Homework.Abstract_Classes;

    public class CSharpExam : Exam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;

        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Score cannot be below 0");
                }

                this.score = value;
            }
        }

        public override ExamResult CalculateScore()
        {
            var result = new ExamResult(this.Score, MinScore, MaxScore, "Exam results calculated by score.");

            return result;
        }
    }
}
