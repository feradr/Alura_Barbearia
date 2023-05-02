using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 02 - Criando Variáveis");

        int idade;
        int DataNascimento = 1995;
        int DataAtual = 2023;

        idade = DataAtual - DataNascimento;
        Console.WriteLine(idade);

        Console.WriteLine("Tecle Enter para fechar....");
        Console.ReadLine();
    }

}