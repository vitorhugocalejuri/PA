using System;

namespace Aula_07_11_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator;

            Console.Write("Informe o Fator: ");
            fator = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
            }
        }
    }
}
