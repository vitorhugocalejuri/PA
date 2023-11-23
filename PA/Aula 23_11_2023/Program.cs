using System;

namespace Aula_23_11_2023
{
    class Program
    {
        static void Main(string[] args)
        {

            int voto = -1;
            int totalVotoCand01 = 0, totalVotoCand02 = 0, totalVotoCand03 = 0,
                totalVotoCand04 = 0, totalVotoNulo = 0, totalVotoBranco = 0,
                totalVotos = 0,
                percVotoNulos = 0,
                 percVotoBrancos = 0;


            while (voto != 0)
            {
                Console.Clear();
                Console.WriteLine("************* Opções *************");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Para votar no 1º Candidato Digite 1  ");
                Console.WriteLine("Para votar no 2º Candidato Digite 2  ");
                Console.WriteLine("Para votar no 3º Candidato Digite 3  ");
                Console.WriteLine("Para votar no 3º Candidato Digite 4  ");
                Console.WriteLine("Para votar Nulo  Digite 5");
                Console.WriteLine("Para votar em Branco Digite 6 ");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Digite a Opção Desejada");


                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Digite seu voto: ");
                voto = int.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 1:
                       totalVotoCand01 +=1;
                        break;
                    case 2:
                        totalVotoCand02 +=1;
                        break;
                    case 3:
                        totalVotoCand03 +=1;
                        break;
                    case 4:
                        totalVotoCand04 +=1;
                        break;
                    case 5:
                        totalVotoNulo +=1;
                        break;
                    case 6:
                        totalVotoBranco += 1;
                        break;

                    default:
                        if (voto != 0)
                        {
                            Console.WriteLine("Voto não computado ");
                            Console.ReadLine();
                        }
                      break;

                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            totalVotos = totalVotoCand01 + totalVotoCand02 + totalVotoCand03 + totalVotoCand04 + totalVotoNulo + totalVotoBranco;

            Console.WriteLine("************ Apuração ************ ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Total de Votos Candidato 01: {totalVotoCand01}");
            Console.WriteLine();
            Console.WriteLine($"Total de Votos Candidato 02: {totalVotoCand02}");
            Console.WriteLine();
            Console.WriteLine($"Total de Votos Candidato 03: {totalVotoCand03}");
            Console.WriteLine();
            Console.WriteLine($"Total de Votos Candidato 04: {totalVotoCand04}");
            Console.WriteLine();
            Console.WriteLine($"Total de Votos Candidato 01: {totalVotoCand01}");
            Console.WriteLine();

            Console.WriteLine($"Total de Votos Nulos: {totalVotoNulo}");
            Console.WriteLine();
            Console.WriteLine($"Total de Votos Brancos: {totalVotoBranco}");
            Console.WriteLine();

            Console.WriteLine($"A percentagem de votos nulos sobre o total de votos é: {(totalVotoNulo / totalVotos) * 100}");
            Console.WriteLine();
            Console.WriteLine($"A percentagem de votos em branco sobre o total de votos é: {(totalVotoBranco / totalVotos) * 100}");

        }
    }
}
