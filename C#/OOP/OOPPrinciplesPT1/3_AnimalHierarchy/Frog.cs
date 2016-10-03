using System;

namespace AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog(int age, string name, Sex sex) : base(age, name, sex)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("cwak - cwak");
        }
    }
}
