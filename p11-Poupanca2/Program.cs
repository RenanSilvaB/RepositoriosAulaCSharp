using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Calcula Poupança");

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++) 
        {
            investimento *= 1.005;
            Console.WriteLine("No " + mes + "° mês você terá R$ " + investimento);

        }




        /*
        while (mes <= 12)
        {
            investimento += investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você terá R$ " + investimento);
            mes += 1;

        }

        */


        Console.WriteLine("tecle enter para fechar");
        Console.ReadLine();
    }
}