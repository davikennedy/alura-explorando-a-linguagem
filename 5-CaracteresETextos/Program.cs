﻿using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra); // Saída: a

        letra = (char)65;
        Console.WriteLine(letra); // Saída: A

        letra = (char)(65 + 1);
        Console.WriteLine(letra); // Saída: B

        string cursos = @"Cursos disponíveis: 
- Go
- C#
- Python
- Java
";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}