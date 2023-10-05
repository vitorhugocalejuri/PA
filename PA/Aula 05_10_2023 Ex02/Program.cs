using System;

namespace Aula_05_10_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;

            Console.Write("Digite um Número: ");
            num1 = float.Parse(Console.ReadLine());
            
            if (num1 >= 10)
            {
                Console.Write("Esse número é igual ou maior que 10 :)");
            }
        }
    }
}
