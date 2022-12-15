using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("executando projeto 11 encadeando o For");

        //*
        //**
        //***
        //****
        //*****

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for( int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            {
                Console.Write("*");
                if(contadorColuna >= contadorLinhas) 
                
                    break;
                                    
                
            }
            Console.WriteLine();

        }


        Console.WriteLine("tecle o enter duas vezes para sair");
        Console.ReadLine();
    }
}