using System;

namespace Aula_14_11_2023_Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|===================================|");
            Console.WriteLine("|    NÚMEROS IMPARES EM VERMELHO    |");
            Console.WriteLine("|===================================|");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Insira um número: ");
            num = int.Parse(Console.ReadLine());


            for (int contador = 0; contador <= num; contador++)
            {

                if (contador % 2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Os números Impares são: {contador} ");
                } 
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Os números Impares são: {contador} ");
                    
                }   

            }
            
        }
    }
}
