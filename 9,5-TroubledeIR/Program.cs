using System;

class CalculoDeIR
{
    static void Main(string[] args)
    {
        double salario = 3131.56;

        string iR = @"O Imposto de Renda(IR) e as regras de alíquota funcionam assim:
O sálario de R$ 1903.98 até R$ 2826.65, o IR é de 7.5 % e pode deduzir na declaração o valor de R$ 142
O sálario de R$ 2826.66 até R$ 3751.05, o IR é de 15 % e pode deduzir R$ 350
O sálario de R$ 3751.06 até R$ 4664.68, o IR é de 22.5 % e pode deduzir R$ 636
O sálario apartir de R$ 4664.68, o IR é de 27,5 % e pode deduzir R$ 869";

        Console.WriteLine(iR);
        Console.WriteLine();
        Console.WriteLine();

        if (salario <= 1903.98)
        {
            Console.WriteLine("ISENTO DO IMPOSTO DE RENDA");
        }
        if (salario >= 1903.99 && salario <= 2826.00)
        {
            Console.WriteLine("O seu salário é de: R$ " + salario + ". O sálario de R$ 1903.98 até R$ 2826.65, o IR é de 7.5 % e pode deduzir na declaração o valor de R$ 142");
        }
        if (salario >= 2800.66 && salario <= 3751.00)
        {
            Console.WriteLine("O seu salário é de: R$ " + salario + ". E o sálario de R$ 2826.66 até R$ 3751.05, o IR é de 15 % e pode deduzir R$ 350");
        }

        if (salario >= 3761.07 && salario <= 4664.68)
        {
            Console.WriteLine("O seu salário é de: R$ " + salario + ". E o sálario de R$ 3751.06 até R$ 4664.68, o IR é de 22.5 % e pode deduzir R$ 636");
        }
        if (salario >= 4664.69)
        {
            Console.WriteLine("O seu salário é de: R$ " + salario + ". E o sálario apartir de R$ 4664.68, o IR é de 27,5% e pode deduzir R$ 869");

        }


        Console.WriteLine("Tecle o Enter duas vezes para fechar...");
        Console.ReadLine();
    }
}
