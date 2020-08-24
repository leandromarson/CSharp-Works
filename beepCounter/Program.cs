using System;
using System.Threading;


namespace beepCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Beep b = new Beep();

            b.play();

            Console.ReadKey();
        }
    }
}
