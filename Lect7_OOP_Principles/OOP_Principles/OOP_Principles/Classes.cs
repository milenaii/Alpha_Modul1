using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Principles
{
    public class Classes : IComment
    {
        private string textIdentifier;

        public Classes(string textIdentifier, List<Teacher> teacherSet, List<Student> studentSet)
        {
            this.TextIdentifier = textIdentifier;
            this.TeacherSet = teacherSet;
            this.StudentSet = studentSet;
        }

        public List<string> Comment { get; set; }

        public List<Teacher> TeacherSet { get; set; }

        public List<Student> StudentSet { get; set; }


        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            private set
            {
                this.textIdentifier = value;
            }
        }

        public override string ToString()
        {
            string result = $"Class: {this.textIdentifier}  \nTeachers: ";

            foreach (Teacher teach in TeacherSet)
            {
                result += teach + " ";
            }
            result += "\nStudents: \n";
            foreach (Student stud in StudentSet)
            {
                result += stud + "\n";
            }

            return result;
        }

        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        }
    }
}

