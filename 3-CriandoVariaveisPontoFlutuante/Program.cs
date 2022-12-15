using System;

class VariavelSalario
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");

        double salario;
        salario = 3173.13;
        int idade;
        idade = 24;

        Console.WriteLine("O salário desejado por mim é de: R$" + salario + 
            ". E eu quero ter esse sálario aos " + idade + " anos");

        double idade2 = salario  * 2;
        double idade3 = salario * 3;
        double idade4 = salario * 4;

        Console.WriteLine("e que meu salário sempre dobre comforme o ano vai passando no 3° ano ficaria assim: " + idade3);

        Console.WriteLine("Pressione Enter duas vezes para fechar...");
        Console.ReadLine();
   
    }
}