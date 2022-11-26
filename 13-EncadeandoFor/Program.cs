using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Encadeando For");

        for (int contadorLinhas = 1; contadorLinhas <= 10; contadorLinhas++)
        {
            for (int contadorColunas = 1; contadorColunas <= 10; contadorColunas++)
            {
                Console.Write("*");
                if (contadorLinhas == contadorColunas)
                    break;
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}