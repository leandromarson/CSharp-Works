using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WindowHeight = 40;//40 lines
            Console.Title = "Variablum Mariablum";
            Console.WriteLine("Whatia NAimE?:");
            String userName = Console.ReadLine();
            Console.WriteLine("SO Iau naime IA: "+userName+"! YAYAYAYA");
            Console.WriteLine("TEL ONU NUMBA!!:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("TEL ODA NUMBA!!:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double res = n1 + n2;
            Console.WriteLine("HAHAHA TA SUMA Of: "+n1+"+"+n2+"="+(res));
            res = n1 - n2;
            Console.WriteLine("HAHAHA TA SUBATRACTIUON Of: "+n1+"-"+n2+"="+(res));
            res = n1 / n2;
            Console.WriteLine("HAHAHA TA DIVISA Of: "+n1+"/"+n2+"="+(res));
            res = n1 * n2;
            Console.WriteLine("HAHAHA TA MULTIPLA Of: "+n1+"*"+n2+"="+(res));
            res = n1 % n2;
            Console.WriteLine("HAHAHA TA MODULIM Of: "+n1+"%"+n2+"="+(res));

            Console.WriteLine("ANOTA NUMB!!");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double med = (n1+n2+n3)/3;

            Console.WriteLine("HAHAHA TA AVARAGIUM Of: "+n1+", "+n2+" and "+n3+"="+med);

            Console.ReadKey();
        }
    }
}
