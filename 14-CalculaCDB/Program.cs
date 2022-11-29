using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        // Esse programa considera um lucro diário de 0.037%
        Console.WriteLine("Projeto 14 - Calcula CDB");

        Console.Write("Valor a ser investido: ");
        double investimentoInicial = double.Parse(Console.ReadLine());
        double investimento = investimentoInicial;

        Console.Write("Em quantos dias pretende resgatar o valor? ");
        int quantidadeDias = int.Parse(Console.ReadLine());

        double fatorRendimento = 1.00037;

        for (int dia = 0; dia < quantidadeDias; dia++)
        {
            investimento *= fatorRendimento;
        }

        Console.WriteLine($"\nDepois de {quantidadeDias} dias, você terá: R$ {(Math.Round(investimento, 2))}");

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadKey();
    }
}