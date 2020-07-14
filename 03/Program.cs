using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
                int troco = money = money - 10;
                Console.WriteLine("YOU BASTARD TAKE $"+troco+" OF TROCO");
                 Console.WriteLine("PICK YO TICKET!");
                 bileta = true;
            }

            if(bileta==true){
                Console.WriteLine("NOW TELL YO HEIGHS(CM)");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ANDI AGES!!!");
                int age = Convert.ToInt32(Console.ReadLine());
                if(height>=150 || age>=15){
                    Console.WriteLine("ENTER BASTARD!!!");
                }else{
                    Console.WriteLine("I GONA KILLU!!");
                }
            }else{
                Console.WriteLine("GET OUT OF DAH YAY BISHMAN!!");
            }

            Console.WriteLine("2+2=");
            int res = Convert.ToInt32(Console.ReadLine());

            if(res == 4){
                Console.WriteLine("CORRECT! TAKE YOUR COIN");
                money = money + 1;
            }else{
                Console.WriteLine("PLAK PLACK PLAK!!!");
            }

            Console.WriteLine("NOW TELL A NUMBER 1 to 10!");
            int number = Convert.ToInt32(Console.ReadLine());

            switch(number){
                case 1:
                    Console.WriteLine("ONE");
                    break;
                case 2:
                    Console.WriteLine("TWO");
                    break;
                case 3:
                    Console.WriteLine("THREE");
                    break;
                case 4:
                    Console.WriteLine("FOUR");
                    break;
                case 5:
                    Console.WriteLine("FIVE");
                    break;
                case 6:
                    Console.WriteLine("SIX");
                    break;
                case 7:
                    Console.WriteLine("SEVEN");
                    break;
                case 8:
                    Console.WriteLine("EIGHT");
                    break;
                case 9:
                    Console.WriteLine("NINE");
                    break;
                case 10:
                    Console.WriteLine("TEN");
                    break;
            }

            Console.WriteLine("YOU HAVE $"+money+"!!!");

            

            Console.ReadKey();


        }
    }
}
