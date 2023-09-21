using System;

namespace Aula_19_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, soma, media;

            Console.WriteLine("Hello Master!");

            Console.Write("Informe a 1° nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 2° nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 3° nota: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 4° nota: ");
            nota4 = float.Parse(Console.ReadLine());

            soma = nota1 + nota2 + nota3 + nota4;
            media = soma / 4;
            Console.WriteLine("A media é " + media);
         

            //0.00 a 4.99 - Reprovado
            //5.00 a 6.99 - Recuperação
            //7.00 a 10 - Aprovado

            if (media <5) 
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Poxa que Pena :( !!!");
            }
            else if ( media <7)
            {
                Console.WriteLine("Recuperação");
                Console.WriteLine("Coragem !!!");
            }
            else 
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Parabens !!!");
            }
            // if == se 
            // else == senão

            // if faz teste condicional apenas com true or false <> sinais de comparação (==) sinal de igualdade (=) atribuição
            // uso das {} só é necessário caso haja mais que uma linha de instrução após o if e else

        }
    }
}