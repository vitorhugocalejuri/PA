using System;

namespace Aula_21_11_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float maiorAltura = 0, menorAltura = 0;
            int contador = 1;

            while (contador <= 15)
            {
                contador++;

                Console.Write($"Informe a sua Altura:  ");
                altura = float.Parse(Console.ReadLine());

                if (altura > maiorAltura)
                    maiorAltura = altura;
                 
                if (altura <= menorAltura || menorAltura == 0 )
                    menorAltura = altura;
                                            
            }
            Console.WriteLine($"A menor altura é: {maiorAltura} ");
            Console.WriteLine($"A menor altura é: {menorAltura} ");

            // Usando o For

            /*
             float maiorAltura = 0;
             float menorAltura = 0;

            for (int contador = 1; contador  <= 15 ; contador ++)           
            {
                contador++;

                Console.Write($"Informe a sua Altura:  ");
                altura = float.Parse(Console.ReadLine());

                if (altura > maiorAltura)
                    maiorAltura = altura;

                if (altura <= menorAltura || menorAltura == 0)
                    menorAltura = altura;

            }

            Console.WriteLine($"A menor altura é: {maiorAltura} ");
            Console.WriteLine($"A menor altura é: {menorAltura} ");
            */

        }
    }
}
