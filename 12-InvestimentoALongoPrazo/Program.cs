using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Investimento à longo prazo");

        Console.Write("Valor a ser investido: ");
        double investimento = double.Parse(Console.ReadLine());

        Console.Write("Em quantos anos pretende resgatar o valor? ");
        int quantidadeAnos = int.Parse(Console.ReadLine());

        double fatorRendimento = 1.005;

        for (int ano = 1; ano <= quantidadeAnos; ano++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001;
        }

        Console.WriteLine($"\nDepois de {quantidadeAnos} anos, você terá: R$ {(Math.Round(investimento, 2))}");

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}