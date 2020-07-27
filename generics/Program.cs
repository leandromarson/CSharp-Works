using System;

namespace generics
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var book = new Book{Isbn = "1332", Title = "C#"};

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());


            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("2213", new Book());

            var number = new Nullable<int>(5);
            System.Console.WriteLine("Has Value ? " + number.HasValue);
            System.Console.WriteLine("Value: " +number.GetValueOrDefault());  



            Console.ReadKey();
        }
    }
}
