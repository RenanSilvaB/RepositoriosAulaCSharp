using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado";

        }
        else
        {
            textoAdicional = "João está sozinho :(";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Seja bem vindo Jon");
            Console.WriteLine(textoAdicional);
        }
        else
        {
            Console.WriteLine("Sai fora jao");
            Console.WriteLine(textoAdicional);


        }

        Console.WriteLine("Tecle o Enter duas vezes para fechar");
        Console.ReadLine();
    }
}


