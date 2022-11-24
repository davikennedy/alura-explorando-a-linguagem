using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 - Atribuições de variáveis");

        int idade = 25;
        int novaIdade = idade;

        Console.WriteLine($"Idade: {novaIdade}");

        idade = 30;

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}