using System;

namespace acessModifiers
{

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.Birthdate = new System.DateTime(1988, 1, 1);
            System.Console.WriteLine(person.Birthdate);

            Console.ReadKey();
            
        }
    }
}
