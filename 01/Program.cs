using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WindowHeight = 40;//40 lines
            Console.Title = "Filosium Obvium";
            Console.WriteLine("Whatia NAimE?:");
            String userName = Console.ReadLine();
            Console.WriteLine("SO Iau naime IA: "+userName+"! YAYAYAYA");
            Console.WriteLine("TEL ONU NUMBA!!:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("TEL ODA NUMBA!!:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            
            Console.ReadKey();
        }
    }
}
