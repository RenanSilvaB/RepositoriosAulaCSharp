using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Investimento a longo prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for(int anos = 1; anos <= 6; anos++)
        {

            for( int mes = 1; mes<= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001;
        }

        Console.WriteLine("Em 6 anos os seus R$ 1000 investidos irá virar R$ " + investimento);
    


        Console.WriteLine("tecle enter duas vezes para sair...");
        Console.ReadLine();
    }
}