using System;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.Title = "DELEGADO ZANGADO";
            Del texto = DelegateMethod;

            texto("Teste");
            texto("Ronaldo MEQUIDONALDO!!");

            MethodWithCallback(289043,4543432,texto);

            Console.ReadKey();

            

        }

        public delegate void Del(string message);

        public static void DelegateMethod(string message){
            Console.WriteLine(message);
        }
        
        public delegate void Delaware(string message);

        public static void MethodWithCallback(int param1, int param2, Del callback){
            callback("The number is: " + (param1 + param2).ToString());
        }


    
    }
}

