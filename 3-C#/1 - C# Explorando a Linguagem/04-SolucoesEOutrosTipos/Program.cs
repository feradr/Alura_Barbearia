using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario; //int suporta até 32bits
        Console.WriteLine(salarioInteiro);

        //é um tipo de variavel de 64bits
        long x;
        x = 200000000000000000;
        Console.WriteLine(x);

        short y;
        y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine(salarioInteiro);
        Console.ReadLine();
    }
}