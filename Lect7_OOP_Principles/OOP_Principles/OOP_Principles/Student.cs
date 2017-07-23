using System;

namespace OOP_Principles
{
    public class Student : Person
    {
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
            :base(name)
        {
            this.uniqueNumber = uniqueNumber;
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            private set
            {
                if (uniqueNumber <= 0)
                {
                    throw new ArithmeticException("The unique number must be better than zero!");
                }
                this.uniqueNumber = value;
            }
        }
        public override string ToString()
        {
            return String.Format("{0}, Number: {1}",base.Name, uniqueNumber);
        }

    }
}
