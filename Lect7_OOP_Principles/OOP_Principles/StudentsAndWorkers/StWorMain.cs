using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAndWorkers
{
    class StWorMain
    {
        public static void Main()
        {
            //Human human = new Human("Ivan", "Ivanov");
            //Console.WriteLine(human);

            List<Student> studentSet = new List<Student>()
            {
                new Student("Dobri","Nemirov", 5),
                new Student("Dimitar","Dimitrov", 2),
                new Student("Ivan","Ivanov", 12),
                new Student("Petar","Petrov", 8),
                new Student("Tcveti","Nemirova", 8),
                new Student("Maria","Ivanova", 1),
                new Student("Doni","Vekilov", 2),
                new Student("Nina","Ninova", 5),
                new Student("Nora","Todorova", 5),
                new Student("Ina","Petrova", 5)
            };

            var studentSortedByGrade = studentSet.OrderBy(x => x.Grade);

            //foreach (var stud in studentSortedByGrade)
            //{
            //    Console.WriteLine(stud);
            //}

            List<Worker> workerSet = new List<Worker>()
          {
              new Worker("Petar", "Petrov",200.5, 8.5d),
              new Worker("Ivan", "Ivanov",180.0, 8.5d),
              new Worker("Ivanka", "Todorova",200.5, 8.5d),
              new Worker("Slavka", "Petrova",100.5, 8.5d),
              new Worker("Simo", "Petrov",200.5, 8.5),
              new Worker("Dimo", "Dimov",150.5, 8.5),
              new Worker("Dimka", "Todorova",180.2, 8.5),
              new Worker("Svetla", "Petrova",200.5, 8.5),
              new Worker("Marina", "Min4eva",300, 8.5),
              new Worker("Pepi", "Petrova",200.5, 10.5),
          };


           var sortByMoneyPerHour =  workerSet.OrderByDescending(x => x.MoneyPerHour());
            foreach (var worker in sortByMoneyPerHour)
            {
                Console.WriteLine("{0:F2}",worker);
            }

            


        }
    }
}
