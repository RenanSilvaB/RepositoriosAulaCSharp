using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        double investimento = 1000;
        int mes = 1;

        // rendimento de 0.5% ( 0.005) ao mês

        //mes 1
        //investimento += investimento * 0.005;
        //mes 2
        //investimento += investimento * 0.005;
        //mes 3
       //investimento += investimento * 0.005;

       

        while (mes <= 12)
        {
            investimento += investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você terá R$ " + investimento);
            mes += 1;
           
        }




        Console.WriteLine("tecle enter para fechar");
        Console.ReadLine();
    }
}