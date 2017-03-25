namespace InheritanceAndPolymorphism.AbstractClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;

    public abstract class Course : ICourse
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        public Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Teacher name cannot be empty");
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value == null)
                {
                    this.students = new List<string>();
                }
                else
                {
                    this.students = value;
                }
            }
        }

        public virtual string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }
    }
}
