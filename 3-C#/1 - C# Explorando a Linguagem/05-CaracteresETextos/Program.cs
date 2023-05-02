using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 05 - Caracteres e Texto");

        //Armazena um Caractere apenas
        char letra = 'a';
        Console.WriteLine("chart: " + letra);

        char letra2ASCII = (char)65;
        Console.WriteLine("Char em ASCII: " + letra2ASCII);

        char letra3ASCII = (char)(65 + 1);
        Console.WriteLine(letra3ASCII);

        char letra4ASCII = (char)(86 + 1);
        Console.WriteLine(letra4ASCII);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}