using System;

namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(int age, string name, Sex sex) : base (age, name, sex)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("meow meow");
        }
    }
}
