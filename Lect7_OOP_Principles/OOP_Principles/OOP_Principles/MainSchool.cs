using System;
using System.Collections.Generic;

namespace OOP_Principles
{
    public class MainSchool
    {
        public static void Main()
        {
            List<Discipline> disciplineSet = new List<Discipline>()
            {
                new Discipline("Art", 45, 30),
                new Discipline("Mathematics", 60, 60),
            };


            List<Discipline> disciplineSet2 = new List<Discipline>()
            {
                new Discipline("Art", 45, 30),
                new Discipline("Music", 60, 60),
                new Discipline("AE", 40, 40)
            };

            List<Teacher> teacherSet = new List<Teacher>()
            {
                new Teacher("P. Ivanov", disciplineSet),
                new Teacher("Sv. Uzunov", disciplineSet2)
            };
            
            // teacherSet.ForEach(x => Console.WriteLine(x));

            List<Student> studentSet = new List<Student>()
            {
                new Student("M. Ivanova", 2703),
                new Student("S. Georgiev", 1505),
                new Student("Sv. Vasilev", 6408)
            };

            Classes classes = new Classes("1b", teacherSet, studentSet);

            Console.WriteLine(classes);

        }
    }
}




