using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;


        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Seja bem vindo Jon");
        }
        else
        {
            Console.WriteLine("Sai fora jao");
        }

        Console.WriteLine("Tecle o Enter duas vezes para fechar");
        Console.ReadLine();
    }
}


