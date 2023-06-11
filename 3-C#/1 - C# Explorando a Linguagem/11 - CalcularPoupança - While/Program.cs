using System;

class Programa
{
    static void Main(string[] args)
    {
        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês

        //mes 01
        //investimento = investimento + investimento * 0.005;


        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);

            //mes = mes + 1;
            //mes += 1;
            mes ++;
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}