using System;
using System.Collections.Generic;

namespace OOP_Principles
{
    public class MainSchool
    {
        public static void Main()
        {
            Discipline discipline = new Discipline("Art", 45, 30);
            Discipline discipline2 = new Discipline("Mathematics", 60, 60);
            Discipline discipline3 = new Discipline("Music", 60, 60);
            Discipline discipline4 = new Discipline("AE", 40, 40);

            List<Discipline> disciplineSet = new List<Discipline>();
            disciplineSet.Add(discipline);
            disciplineSet.Add(discipline2);

            List<Discipline> disciplineSet2 = new List<Discipline>();
            disciplineSet.Add(discipline3);
            disciplineSet.Add(discipline4);


            Teacher teacher = new Teacher("P. Ivanov", disciplineSet);
            Teacher teacher2 = new Teacher("Sv. Uzunov", disciplineSet2);

            List<Teacher> teacherSet = new List<Teacher>();
            teacherSet.Add(teacher);
            teacherSet.Add(teacher2);

           // teacherSet.ForEach(x => Console.WriteLine(x));

            Student student = new Student("M. Ivanova", 2703);
            Student student2 = new Student("S. Georgiev", 1505);
            Student student3 = new Student("Sv. Vasilev", 6408);

            List<Student> studentSet = new List<Student>();
            studentSet.Add(student);
            studentSet.Add(student2);
            studentSet.Add(student3);

            //Person person = new Person("Ivan Petrov");
            //Console.WriteLine("Person: " + person);

            Classes classes = new Classes("1b", teacherSet,studentSet);

            Console.WriteLine(classes);

        }
    }
}




