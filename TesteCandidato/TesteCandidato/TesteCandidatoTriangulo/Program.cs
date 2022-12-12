using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCandidatoTriangulo
{
    class Program
    {
        string dadosTriangulo;
        static void Main(string[] args)
        {
            Triangulo tr = new Triangulo();
            string dadosTriangulo;
            int numLinhas;
            int resultado = 0;

            Console.WriteLine("Teste do Triângulo\n");
            Console.WriteLine("Insira o número de linhas que o triângulo\n");
            numLinhas = int.Parse(Console.ReadLine());

            resultado = tr.ResultadoTriangulo(numLinhas);

            Console.WriteLine("\nO resultado da soma dos valores é: " + resultado);

            Console.WriteLine("\nPrecione enter para sair.");
            Console.ReadLine();

        }
    }
}
