namespace Methods
{
    using System;

    public class Student
    {
        private const int MinNameSymbols = 3;
        private const int MaxNameSymbols = 16;

        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string additionalInformation;

        public Student(string firstName, string lastName, DateTime birthDate, string additionalInformation)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.AdditionalInformation = additionalInformation;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentException($"Firstname must be between {MinNameSymbols} and {MaxNameSymbols} symbols");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentException($"Lastname must be between {MinNameSymbols} and {MaxNameSymbols} symbols");
                }

                this.lastName = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }

            set
            {
                bool isValidDate = value.Year < DateTime.Now.Year;
                bool isOldEnough = DateTime.Now.Year - value.Year >= 7;

                if (!isValidDate)
                {
                    throw new ArgumentException("Invalid birth date");
                }

                if (!isOldEnough)
                {
                    throw new ArgumentException("The person is too young for a student.");
                }

                this.birthDate = value;
            }
        }

        public string AdditionalInformation
        {
            get
            {
                return this.additionalInformation;
            }

            set
            {
                this.additionalInformation = value;
            }
        }

        public bool IsOlderThan(Student otherStudent)
        {
            DateTime firstDate = this.birthDate;
            DateTime secondDate = otherStudent.BirthDate;

            var result = firstDate > secondDate;

            return result;
        }
    }
}
