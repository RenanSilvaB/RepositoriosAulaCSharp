using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int parapeito;
        int idade;
        idade = 27;
        Console.WriteLine(idade);

        parapeito = idade - 10;

        Console.WriteLine("minha idade em 100 anos seria: " + parapeito);
        

        Console.WriteLine("Pressione Enter para fechar...");
        Console.ReadLine();
    }
}