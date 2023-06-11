using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança" + Environment.NewLine);

        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês

        investimento = investimento + investimento * 0.005;

        Console.WriteLine("Valor atual: " + investimento + Environment.NewLine);

        Console.WriteLine("Tecle enter para fechar!...");
        Console.WriteLine();
    }
}