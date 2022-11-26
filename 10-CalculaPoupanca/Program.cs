using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        Console.Write("Valor a ser investido: ");
        double investimento = double.Parse(Console.ReadLine());

        Console.Write("Em quantos meses pretende resgatar o valor? ");
        int quantidadeMeses = int.Parse(Console.ReadLine());

        int mes = 1;
        while (mes <= quantidadeMeses)
        {
            investimento *= 1.005;
            Console.WriteLine($"Valor no {mes}º mês: R$ {(Math.Round(investimento, 2))}");
            mes++;
        }

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}