using System;

namespace Aula_07_11_2023_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite o Número Desejado: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O número é Par: ");
            else
                Console.WriteLine("O número é Impar: ");


        }
    }
}
