using System;

    class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 6 - Atribuições de Variaveis");

        int idade = 30;
        int idadeAna = idade;

        idade = 25;
        idadeAna = idade;

        Console.WriteLine(idadeAna);

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}
