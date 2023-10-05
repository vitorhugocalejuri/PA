using System;

namespace Aula_05_10_2023Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;

            Console.Write("Qual o Salário: ");
            salario = float.Parse(Console.ReadLine());

            if (salario <= 3000)
            {
                Console.Write("O seu salario foi reajustado em 50%: ");
                Console.WriteLine(salario * 0.5 + salario);
            }
            else if (salario <= 7000)
            {
                Console.Write("O seu salario foi reajustado em 20%: ");
                Console.WriteLine(salario * 0.2 + salario);
            }
             else if (salario <= 10000 )
            {
                Console.Write($"O seu salario foi reajustado em 15%: {salario * 0.15 + salario}");
                //Console.WriteLine(salario * 0.15 + salario);
            }
            else
            {
                Console.Write("O salário de quem recebe acima de 10000 foi reajustado em 10%: ");
                Console.WriteLine(salario * 0.10 + salario);
            }
        
        
        
        }
    }
}
