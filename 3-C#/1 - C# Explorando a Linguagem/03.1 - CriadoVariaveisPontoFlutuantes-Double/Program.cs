using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");
        
        double salario = 1250.70;
        Console.WriteLine(salario);

        salario = 3000.10;
        Console.WriteLine("Meu Salario é: " + salario);

        //int valor = 12.5; //não conpila, fortemente tipado
        //Console.WriteLine(valor);

        //int divisao = 7 / 5;
        Double divisao = 7.0 / 5;
        Console.WriteLine(divisao);

        Console.ReadLine();
    }
}


