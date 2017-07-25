using System;

namespace AnimalHierarchy
{
    public class Dog : Animal
    {
        public Dog(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
        }

        public override string MakeSound()
        {
            string result = "Bau bau";
            return result;
            //Console.WriteLine("Bau bau!");
        }
        public override string ToString()
        {
            return base.ToString() + ", " + MakeSound();
        }

        


    }
}
