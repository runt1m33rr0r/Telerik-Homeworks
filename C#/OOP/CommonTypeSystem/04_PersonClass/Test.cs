namespace _04_PersonClass
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Person person1 = new Person("Ivan Ivanov", 33);
            Person person2 = new Person("Teodora Petrova");
            Person person3 = new Person("Georgi Georgiev", 0);

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);
        }
    }
}
