using System;

namespace AnimalHierarchy
{
    public class Dog : Animal
    {
        public Dog(int age, string name, Sex sex) : base(age, name, sex)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("bau - bau");
        }
    }
}
