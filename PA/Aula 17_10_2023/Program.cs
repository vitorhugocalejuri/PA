using System;

namespace Aula_17_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My Brother!");

            float num1, num2;
            string operador;

            Console.Write("Digite um némero: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            num2 = float.Parse(Console.ReadLine());

            Console.Write("Escolha o Operador: ");
            operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    Console.Write("A soma dos valores é: ");
                    Console.Write(num1 + num2);
                    break;
                case "-":
                    Console.Write("A subtração dos valores é: ");
                    Console.Write(num1 - num2);
                    break;
                case "*":
                    Console.Write("A multiplicação dos valores é: ");
                    Console.Write(num1 * num2);
                    break;
                case "/":
                    Console.Write("A divisão dos valores é: ");
                    Console.Write(num1 / num2); 
                    break;
                default:
                    Console.WriteLine("Operador Inválido");
                    break;
            }
            
        }
    }
}
