using System;

namespace Aula_19_10_2023_While_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator;
            int numeroFinal;

            Console.Write("Informe o Fator: ");
            fator = int.Parse(Console.ReadLine());

            Console.Write("Informe o Nº Final: ");
            numeroFinal = int.Parse(Console.ReadLine());


            int contador = 1;
            while (contador <= numeroFinal)
            {
                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
                /*contador = contador + 1;*/
                contador++; /*++ é igual a própria variável +1 / -- é igual a variável -1*/
            }
            Console.WriteLine("*** Fim da Tabuada ***");
        }
    }
}
