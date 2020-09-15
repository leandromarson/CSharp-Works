using System;
using System.Threading;

namespace beepCounter
{

    public class Beep
    {

        Int32 len = 32767;

        public void play()
        {

            try
            {
                System.Console.WriteLine("Begin\n");
                System.Threading.Thread.Sleep(1000);
                for (Int32 i = 37; i <= len; i++)
                {
                    System.Console.WriteLine($"Frequency: {i}");
                    Console.Beep(i, 1000);
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }

    }
}