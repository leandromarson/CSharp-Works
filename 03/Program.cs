using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WindowHeight = 20;//40 lines
            Console.Title = "CHOICUS!";
            Console.WriteLine("PAY MY MONEY $10 CONTOS!");
            int money = Convert.ToInt32(Console.ReadLine());
            
            Boolean bileta = false;
            if(money < 10){
                Console.WriteLine("YOU MISESABLE! IS 10 BULLAT!!");
                bileta = false;
            }else if(money == 10){
                Console.WriteLine("HAHAHAHA!");
                Console.WriteLine("PICK YO TICKET!");
                bileta = true;      

            }else{
                int troco = money - 10;
                Console.WriteLine("YOU BASTARD TAKE $"+troco+" OF TROCO");
                 Console.WriteLine("PICK YO TICKET!");
                 bileta = true;
            }

            if(bileta==true){
                Console.WriteLine("NOW TELL YO HEIGHS(CM) ANDI AGES!!!");
                int height = Convert.ToInt32(Console.ReadLine());
                int age = Convert.ToInt32(Console.ReadLine());
                if(height>=150 || age>=15){
                    Console.WriteLine("ENTER BASTARD");
                }else{
                    Console.WriteLine("I GONA KILLU!!");
                }
            }else{
                Console.WriteLine("GET OUT OF DAH YAY BISHMAN!!");
            }



            Console.ReadKey();


        }
    }
}
