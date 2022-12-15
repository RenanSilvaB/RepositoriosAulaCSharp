using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio - Múltiplos de 3");

        // o I representa o numero "1" e se ele for menor que 100 ele vai ser adicionado mais "1".
        for (int i = 1; i <= 100; i++ )

            // se o Numero que o "I" representar for divisivel por 3 e o resultador for o numero "0" imprima ele.
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }

        Console.WriteLine("Aperte Enter duas vezes para fechar...");
        Console.ReadLine();
    }

}