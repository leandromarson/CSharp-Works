using System;

namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal(878586897,"Verde","Jurumão");
            animal.Comer();
            animal.Correr();
            animal.FazerBarulho();
            
            System.Console.WriteLine("Nome => "+animal.Nome);
            System.Console.WriteLine("Cor => "+animal.Cor);
            System.Console.WriteLine("Num. patas => "+animal.NumPatas+"\n");

            var jur = new Jurimbabo();

            jur.Comer();
            jur.FazerBarulho();
            jur.Correr();


            Console.ReadKey();
        }
    }
}
