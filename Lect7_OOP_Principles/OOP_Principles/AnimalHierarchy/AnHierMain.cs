using System;
using System.Linq;

namespace AnimalHierarchy
{
    class AnHierMain
    {
        static void Main()
        {
            Dog dog = new Dog("Dark", 5, true);
            Console.WriteLine(dog);

            Frog frog = new Frog("Jaburana", 3, false);
            Console.WriteLine(frog);

            Kitten kitten = new Kitten("Pisana", 2);
            Console.WriteLine(kitten);

            Tomcat tomcat = new Tomcat("Tom", 2);
            Console.WriteLine(tomcat);

            Dog[] dogs = new Dog[]
                {
                new Dog("Dark",2, true),
                new Dog("Mark",1, true),
                new Dog("Vark",2, true),
                new Dog("Lara",3, false)
                 };
            Frog[] frogs = new Frog[]
                {
                new Frog("Jaburan4o",1, true),
                new Frog("Jab4o",2, true),
                new Frog("Jaja",4, false),
                new Frog("Jaburana",4, false),
                 };

            Cat[] cats = new Cat[]
                {
                    new Cat("Street Excellent", 3, false),
                    new Cat("Home Excellent", 5, false),
                    new Cat("Persiiko", 1, true),
                    new Cat("Garfield", 7, true)
                };

            Kitten[] kittens = new Kitten[]
            {
                new Kitten("Pisana", 3),
                new Kitten("Pis", 10),
                new Kitten("Pisun", 6),
                new Kitten("Pissss", 2),
                new Kitten("MacPis", 4),
            };

            Tomcat[] tomcats = new Tomcat[]
                {
                    new Tomcat("Kotio", 5),
                    new Tomcat("Gosho", 4),
                    new Tomcat("Pesho", 8)
                };

            double dogsAverageAge = dogs.Average(x => x.Age);
            double frogAverageAge = frogs.Average(x => x.Age);
            double catAverageAge = cats.Average(x => x.Age);

            Console.WriteLine(dogsAverageAge);
            Console.WriteLine(frogAverageAge);
            Console.WriteLine(catAverageAge);



            //или с метод в Animal
            //double dogsAverageAge = Animal.AverageAge(dogs);



        }
    }
}
