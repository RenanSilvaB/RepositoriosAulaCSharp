using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Seja bem vindo Jon");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Pode vim jon, você está acompanhado de um adulto!");
            }
            else
            {
                Console.WriteLine("Sai fora jao");
            }

        }

        Console.WriteLine("Tecle o Enter duas vezes para fechar");
        Console.ReadLine();
    }
}

