using System;
using System.Collections.Generic;

namespace OOP_Principles
{
    public class Person : IComment
    {
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Enter valid name!");
                }
                this.name = value;
            }
        }

        public List<string> Comment{ get; set; }

        public override string ToString()
        {
            return String.Format("{0}", name);
        }

        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        }
    }
}
