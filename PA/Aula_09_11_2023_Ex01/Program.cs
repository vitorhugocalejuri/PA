using System;

namespace Aula_09_11_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "S";
            

            while (resposta.ToUpper() == "S")
            {
                Console.Clear();

                CalcularTabuada();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Deseja Continua? (S/N)");
                resposta = Console.ReadLine();
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*** FIM ***");
        }
        static void CalcularTabuada()
        {
            int fator, multiplicador;

            Console.WriteLine("Qual fator você deseja utilizar na tabuada? ");
            fator = int.Parse(Console.ReadLine());

            Console.WriteLine("Até quanto você deseja multiplicar? ");
            multiplicador = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= multiplicador; contador++)
            {
                if (contador % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
            }

        }
    }
}
