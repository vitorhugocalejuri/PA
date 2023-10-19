using System;

namespace Aula_19_10_2023_While_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator;

            Console.Write("Informe o Fator: ");
            fator = int.Parse(Console.ReadLine());

            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
                /*contador = contador + 1;*/
                contador++; /*++ é igual a própria variável +1 / -- é igual a variável -1*/
            }
            Console.WriteLine("*** Fim da Tabuada ***");
        }
    }
}
