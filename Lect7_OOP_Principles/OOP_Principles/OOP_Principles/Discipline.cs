using System;
using System.Collections.Generic;

namespace OOP_Principles
{
    public class Discipline : IComment
    {
        public Discipline(string nameDisc, int numLect, int numExerc)
        {
            this.NameDiscipline = nameDisc;
            this.NumberOfLectures = numLect;
            this.NumberOfExercise = numExerc;
        }

        public string NameDiscipline { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercise { get; set; }
        public List<String> Comment { get; set; }


        public override string ToString()
        {
            return "Discipline: " + NameDiscipline + " -  Lectures: " + NumberOfLectures + "h Exercise: " + NumberOfExercise + "h";
        }

        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        }

    }
}
