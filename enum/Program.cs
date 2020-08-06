using System;

namespace Enum
{
    class Program
    {
        public enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
        public enum Meses{Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro}

        static void Main(string[] args)
        {
            DiasSemana dom = DiasSemana.Domingo;//enum direto
            DiasSemana ind = (DiasSemana)4;//index convertido em enum
            int index = (int)DiasSemana.Sexta;//index da sexta

            int countSemana = DiasSemana.GetValues( typeof( DiasSemana ) ).Length;

            System.Console.WriteLine(dom);
            System.Console.WriteLine(ind);
            System.Console.WriteLine(index);

            System.Console.WriteLine("\nDias da semana!");

            for(int x = 0; x<countSemana; x++){
                DiasSemana aux = (DiasSemana)x;
                System.Console.WriteLine((x+1)+". "+aux);
            }

            int countMeses = Meses.GetValues( typeof( Meses ) ).Length;

            System.Console.WriteLine("\nMêses do ano!");

            for(int x = 0; x<countMeses; x++){
                Meses aux = (Meses)x;
                System.Console.WriteLine((x+1)+". "+aux);
            }

            Console.ReadKey();            
        }
    }
}
