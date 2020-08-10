using System;
using System.Threading;

namespace csharpner
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jonas Broder";
            string nombre = "Malinete Porrete";
            Console.WriteLine($"Hello {name} and {nombre}!");
            System.Console.WriteLine($"{name} have {name.Length} letters!");
            System.Console.WriteLine($"{nombre} tienes {nombre.Length} letras!");

            System.Console.WriteLine("\n");

            string greeting = "    Hello World!    ";
            System.Console.WriteLine($"[{greeting}]");
            
            string trimS = greeting.TrimStart();
            string trimE = greeting.TrimEnd();
            string trim = greeting.Trim();

            System.Console.WriteLine($"[{trimS}]");
            System.Console.WriteLine($"[{trimE}]");
            System.Console.WriteLine($"[{trim}]");

            System.Console.WriteLine("\n");

            string sayHello = "Hello World!";
            System.Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            System.Console.WriteLine(sayHello);
            System.Console.WriteLine(sayHello.ToUpper());
            System.Console.WriteLine(sayHello.ToLower());

            System.Console.WriteLine("\n");

            string songLyrics = "You say goodbye, and I say hello";

            System.Console.WriteLine(songLyrics);
            System.Console.WriteLine(songLyrics.Contains("goodbye"));
            System.Console.WriteLine(songLyrics.Contains("greetings"));
            
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));

            System.Console.WriteLine("\n");

            double googol = 1*(Math.Pow(10,100));

            System.Console.WriteLine("GOOGOL: "+ googol);
            Thread.Sleep(1000);
            System.Console.WriteLine("\n10 seconds!\n");
            
            for(int x=10; x>=1;x--){
                System.Console.WriteLine(x);
                Thread.Sleep(1000);
            }
            
            System.Console.WriteLine("\nGO\n");
            Thread.Sleep(1000);

            for(double x0 = 1; x0 <= googol; x0++){
                System.Console.WriteLine(x0);
            }
            


            Console.ReadKey();
        }
    }
}
