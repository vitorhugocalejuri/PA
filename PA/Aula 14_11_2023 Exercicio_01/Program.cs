using System;

namespace Aula_14_11_2023_Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|=================|");
            Console.WriteLine("|    SUBTRAÇÃO    |");
            Console.WriteLine("|=================|");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 1; i <=3; i++)
            {

                Console.Write("Digite um Número: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite outro Número: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"A subtração dos números é: {num1 - num2}");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(); 
            }

            

        }
    }
}
