using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Condicionais 2");

        int idade = 16;
        int quantidadePessoas = 2;

        bool maiorDeIdade = idade >= 18;
        bool acompanhado = quantidadePessoas > 1;

        if (maiorDeIdade || acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}