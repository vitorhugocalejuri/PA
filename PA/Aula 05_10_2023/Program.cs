using System;

namespace Aula_05_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {
          
            float num1, num2;
            string operador;

            Console.Write("Digite um némero: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            num2 = float.Parse(Console.ReadLine());

            Console.Write("Escolha o Operador: ");
            operador = Console.ReadLine();

            if (operador == "+")
            {
                Console.Write(num1 + num2);
            }
            else if (operador == "-")
            {
                Console.Write(num1 - num2);
            }
            else if (operador == "*")
            {
                Console.Write(num1 * num2);
            }
            else if (operador == "/")
            {
                Console.Write(num1 / num2);
            }

        }
    }
}
