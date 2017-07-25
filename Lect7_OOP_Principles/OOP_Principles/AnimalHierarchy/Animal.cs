using System;
using System.Linq;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        public Animal(string name, int age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool IsMale { get; private set; }

        public abstract string MakeSound();

        public override string ToString()
        {
            return $"Name: {Name}, Is Male: {IsMale}, Age: {Age}";
        }

        //public static double AverageAge(Animal[] arr)
        //{
        //    return arr.Average(x => x.Age);
        //}

    }
}
