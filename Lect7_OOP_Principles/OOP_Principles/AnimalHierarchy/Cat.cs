using System;

namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
        }

        public override string MakeSound()
        {
            string result = "Miau miau";
            return result;
        }
        public override string ToString()
        {
            return base.ToString() + ", " + MakeSound();
        }
    }
}
