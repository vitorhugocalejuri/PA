using System;

namespace Aula_26_10_2023__Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|-----------------------|");
            Console.WriteLine("|--- Atividade Ex 02 ---|");
            Console.WriteLine("|-----------------------|");

            float valorFinanciado, valorParcela;
            int qtdeParcela, contador = 1;

            Console.Write("Informe o valor Financiado: ");
            valorFinanciado = float.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de Parcelas: ");
            qtdeParcela = int.Parse(Console.ReadLine());

            valorParcela = valorFinanciado / qtdeParcela;

            DateTime data = DateTime.Now.Date;

            while (contador <= qtdeParcela)
            {
                //Console.WriteLine($"{contador}º parcela: {valorFinanciado / qtdeParcela}"); outras maneiras de fazer o calculo
                //Console.WriteLine($"{contador}ª parcela: {valorParcela:0.00}");
                 Console.WriteLine($"{contador}ª parcela ({data}): {qtdeParcela:0.00}");
                //Console.WriteLine($"{contador}ª parcela: {valorFinanciado / qtdeParcela:0.00}");
                contador++;
                data = data.AddMonths(1);
            }
        }
    }
}
