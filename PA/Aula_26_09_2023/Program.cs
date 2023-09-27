using System;

namespace Aula_26_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Master!");

            float nota1, nota2, nota3, nota4, soma, media, percFreq; //percFreq é Percentual de Frequência

            Console.Write("Informe a 1° nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 2° nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 3° nota: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 4° nota: ");
            nota4 = float.Parse(Console.ReadLine());

            Console.Write("Informe o % de frequência: ");
            percFreq = float.Parse(Console.ReadLine());

            soma = nota1 + nota2 + nota3 + nota4;
            media = soma / 4;

            //0.00 a 4.99 e % Frequência <= 40 - Reprovado
            //5.00 a 6.99 e % Frequência <= 60 - Recuperação
            //7.00 a 10   e % Frequência > 60 - Aprovado

            if (media < 5 && percFreq <= 40)
            {
                Console.WriteLine("Aluno Reprovado");
            } else if (media < 7 && percFreq <= 60)
            {
                Console.WriteLine("Aluno em Recuperação");
            } else if (media >= 7 && percFreq > 60)
            {
                Console.WriteLine("Aluno Aprovado");
            } else
            {
                Console.WriteLine("Será analisado pela secretária acadêmica");
            }


        }
    }
}
