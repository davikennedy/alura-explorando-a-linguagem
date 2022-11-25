using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Escopo");

        int idade = 16;
        int quantidadePessoas = 2;

        bool maiorDeIdade = idade >= 18;
        bool acompanhado = quantidadePessoas > 1;

        // Essa variável precisa ser declarada fora do escopos das condicionais 'if'
        string textoAdicional;

        if (acompanhado)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "João não está acompanhado";
        }

        if (maiorDeIdade || acompanhado)
        {
            Console.WriteLine(textoAdicional);
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