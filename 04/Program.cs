using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Numero:");
            int count = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= count; i++){
                double result = Math.Pow(2, i);
                Console.WriteLine(i+", "+result);
                
            }

            Random numberGen = new Random();

            int roll = 0;
            int attempts = 0;

            Console.WriteLine("Press Key");
            while(roll != 6){
                Console.ReadKey();
                roll = numberGen.Next(1, 7);
                Console.WriteLine("Ramdom: "+roll);
                attempts++;
            }
            
            Console.WriteLine(attempts+" to roll "+roll);
            Console.ReadKey();
        }
    }
}
