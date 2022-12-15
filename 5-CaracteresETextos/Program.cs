using System;

class program
{
   static void Main(string[] args)
    {
     Console.WriteLine("executando o projeto 5");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 5);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura = Cursos de Programação.";
        Console.WriteLine(primeiraFrase);

        string cursos = @"Curos da Alura que estão disponiveis para Back-End: 
            = C#  
            - Python 
            - Java 
            - Node.js 
            - Javascript direcionado a Back-End";
        Console.WriteLine(cursos);

     Console.WriteLine("tecle entre duas vezes para fechar");
     Console.ReadLine();
    }   
 }