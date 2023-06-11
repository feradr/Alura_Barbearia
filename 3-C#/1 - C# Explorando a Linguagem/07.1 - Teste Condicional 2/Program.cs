using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando Condicionais");

        int idade = 16;
        int quantidadePessoas = 3;
        bool acompanhado = false;

        //if (idade >= 18 || quantidadePessoas <= 2)
        //{
        //    Console.WriteLine("Seja bem vindo");
        //    Console.ReadLine();
        //}

        if (idade >= 18 && acompanhado == true)
        {
            Console.WriteLine("Seja bem vindo");
        }
        else
        {
            Console.WriteLine("Infelizmente você não pode entrar");
            Console.ReadLine();
        }
    }
}