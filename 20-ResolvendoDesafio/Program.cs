using System;

Console.WriteLine("Escreva uma letra maiúscula: ");

string input = Console.ReadLine();
char inputChar = char.Parse(input);
char letra = ' ';

for (int i = 65; i <= 90; i++)
{
    letra = (char)i;
    if (inputChar == letra)
    {
        Console.WriteLine("Você escreveu uma letra maiúscula");
    }
    else
    {
        Console.WriteLine("Você escreveu uma caracter inválido");
    }
}

Console.WriteLine($"Você escreveu {input}");