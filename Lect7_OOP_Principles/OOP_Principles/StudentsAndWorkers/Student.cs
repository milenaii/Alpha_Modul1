using System;

namespace StudentsAndWorkers
{
    public class Student: Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            :base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Grade must be in the range [1..12]");
                }
                this.grade = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + " " + grade;
        }
        

    }
}
