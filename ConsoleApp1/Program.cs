using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cat cat = new Cat();
            Cat.SayMew("I'm a cute cat!!");
        }
    }

    class Cat
    {
        // [Localizable(true)]
        public static void SayMew(string message)
        {
            Console.WriteLine(message);
        }
    }
    
    public class Person
    {
        public string Name { get; set; } // Auto-property can be made get-only

        public Person(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public override string ToString()
        {
            return $"NAME: {Name.ToUpper()}";
        }
    }

}