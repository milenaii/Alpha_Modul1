using System;

namespace AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog(string name, int age, bool isMale)
            : base(name, age, isMale)
        {

        }

        public override string MakeSound()
        {
            string result = "Kva-kva";
            return result;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + MakeSound();
        }
    }
}
