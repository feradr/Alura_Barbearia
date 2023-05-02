using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("05.02 Caracteres e Texto Foreatch");

        string[] nomes = {"Adrians", "Emilly", "Rosivane", "Leni", "Thales", "Kayron", "Meirinha" };

        foreach (string pessoas in nomes)
        {
            Console.WriteLine("{0}", pessoas);
        }

        Console.ReadLine();
    }
}