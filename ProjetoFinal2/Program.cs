﻿using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio - Fatorial");

        int fatorial = 1;


        for (int i = 1; i <= 10; i++)
        {

            fatorial *= i;

            Console.WriteLine(i + "! = " + fatorial);
        }

        Console.WriteLine("Aperte Enter duas vezes para fechar...");
        Console.ReadLine();
    }

}