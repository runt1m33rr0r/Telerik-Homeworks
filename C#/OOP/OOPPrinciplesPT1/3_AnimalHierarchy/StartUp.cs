namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            var animals = new List<Animal>()
            {
                new Cat(2, "Misho", Sex.male),
                new Tomcat(5, "Tom"),
                new Kitten(4, "Kitty"),
                new Dog(3, "Charlie", Sex.male),
                new Frog(1, "Penka", Sex.female)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();
            Console.WriteLine("Average age: {0}", Animal.AverageAge(animals));
            Console.WriteLine();

            foreach (var animal in animals)
            {
                Console.Write("{0} say: ", animal.Name);
                animal.MakeSound();
            }
        }
    }
}
