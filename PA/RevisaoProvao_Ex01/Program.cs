using System;

namespace RevisaoProvao_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 10)
            {
                //Fazer tabuada do 5

                for (int contador = 1; contador <= 10; contador++)
                {
                    Console.WriteLine($"5 x {contador} = {5 * contador}");
                }
            }

            else
            {   
                 
                //Fazer tabuada do 8
                for (int contador = 1; contador <= 10; contador++)
                {
                    Console.WriteLine($"8 x {contador} = {8 * contador}");
                }
            }
        }
    }
}
