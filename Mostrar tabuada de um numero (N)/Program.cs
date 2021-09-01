using System;

namespace Mostrar_tabuada_de_um_numero__N_
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicando;

            Console.Write("\t\t\t\tInforme o número a ser multiplicado: ");
            multiplicando = Convert.ToInt32(Console.ReadLine());

            for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
                Console.WriteLine(string.Format("\t\t\t\t{0}\t*\t{1}\t=\t{2}", multiplicando, multiplicador, multiplicando*multiplicador));
           
            Console.Write("\n\t\t\t\tPressione enter para finalizar!");
            Console.ReadKey();
            

        }
    }
}
