using System;
using System.Collections.Generic;

namespace OOP_Principles
{
    public class Teacher : Person
    {
        public Teacher(string name, List<Discipline> disciplineSet)
            : base(name)
        {
            this.DisciplineSet = disciplineSet;
        }

        public List<Discipline> DisciplineSet { get; set; }

        public override string ToString()
        {
            string result = "Name: " + base.Name + ", ";
            foreach (Discipline disc in DisciplineSet)
            {
                result += disc + "\n";
            }
            return result;
        }

    }
}
