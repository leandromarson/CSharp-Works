using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc",out number);
            if(result)
                System.Console.WriteLine(number);
            else
                System.Console.WriteLine("Conversion failed.");

            Console.ReadKey();
        }

        public void UseParams(){
            var calculator = new Calculator();
            System.Console.WriteLine(calculator.Add(4, 2, 6, 1, 7, 8));
            Console.ReadKey();
        }

        public void UsePoints(){
            try{
                var point = new Point(40, 90);
                point.Move(null);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(200,400);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                
                
            }catch(Exception){
                System.Console.WriteLine("Unnexpected error!");
            }finally{
                Console.ReadKey();
            }

        }
    }
}
