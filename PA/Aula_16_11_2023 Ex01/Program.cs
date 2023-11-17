using System;

namespace Aula_16_11_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int contador = 0;
            int somaIdade = 0;


            do
            {

                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade == 0)
                    break;
                somaIdade += idade;
                contador++;

            } while (idade != 0);

            Console.Write($"A soma das Idades é: {somaIdade / contador}");

        }
    }
}
