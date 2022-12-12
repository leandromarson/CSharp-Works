using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCandidatoTriangulo
{
    public class Triangulo
    {
        /// <summary>
        ///    6
        ///   3 5
        ///  9 7 1
        /// 4 6 8 4
        /// Um elemento somente pode ser somado com um dos dois elementos da próxima linha. Como o elemento 5 na Linha 2 pode ser somado com 7 e 1, mas não com o 9.
        /// Neste triangulo o total máximo é 6 + 5 + 7 + 8 = 26
        /// 
        /// Seu código deverá receber uma matriz (multidimensional) como entrada. O triângulo acima seria: [[6],[3,5],[9,7,1],[4,6,8,4]]
        /// </summary>
        /// <param name="dadosTriangulo"></param>
        /// <returns>Retorna o resultado do calculo conforme regra acima</returns>
        public int ResultadoTriangulo(int numLinhas)
        {
            //Declaração de variaveis
            int[,] dadosTrianguloArray = new int[numLinhas, numLinhas];
            int numColunas = 1;            

            //Inserindo valores no Array
            for (int i = 0; i < numLinhas; ++i)
            {
                for (int j = 0; j < numColunas; j++)
                {
                    Console.WriteLine("\nDigite o valor da linha [{0}] coluna [{1}]]: ", i,j);
                    Console.WriteLine();
                    dadosTrianguloArray[i, j] = int.Parse(Console.ReadLine());                    
                    
                }
                numColunas++;
            }

            //Imprimindo matriz na tela
            numColunas = 1;
            Console.WriteLine("\nImprimindo Triângulo\n");
            for (int i = 0; i < numLinhas; ++i)
            {
                for (int j = 0; j < numColunas; j++)
                {
                    Console.Write(dadosTrianguloArray[i, j]);
                }
                Console.WriteLine();
                numColunas++;
            }

            int idColuna = 0;
            int aux = 0;
            int resultado = 0;

            //Realizando soma de valores
            Console.WriteLine("\n");
            for (int i = 0; i < numLinhas; ++i)
            {
                if (i == 0)
                {
                    aux = dadosTrianguloArray[0, 0];
                    resultado += dadosTrianguloArray[0, 0];
                }
                else
                {
                    Console.WriteLine("Deseja somar o valor {0} com {1} ou {2}?\n", aux, dadosTrianguloArray[i, idColuna], dadosTrianguloArray[i, idColuna + 1]);
                    int selecionado = int.Parse(Console.ReadLine());

                    while (true)
                    {
                        int valor1 = dadosTrianguloArray[i, idColuna];
                        int valor2 = dadosTrianguloArray[i, idColuna+1];

                        if (selecionado != valor1 && selecionado != valor2)
                        {
                            Console.WriteLine("\nValor inválido! Insira novamente.\n");
                            selecionado = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            break;
                        }

                    }
                    
                    aux = selecionado;

                    if(aux == dadosTrianguloArray[i, idColuna])
                    {
                        idColuna = idColuna;
                    }
                    else
                    {
                        idColuna = idColuna + 1;
                    }

                    resultado += aux;
                }
                Console.WriteLine("\n");
            }           

            return resultado;
        }
    }
}
