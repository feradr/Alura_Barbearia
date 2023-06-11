using System;

class Programa
{
    static void Main(String[] args)
    {
        string nome = "João";
        int idade = 16;
        int quantidadePessoal = 2;

        bool acompanhado = quantidadePessoal > 1;

        //string textoAdicional;
        string textoAdicional;

        if (acompanhado == true)
        {
            

            textoAdicional = nome + " Está acompanhado";
            Console.WriteLine(textoAdicional);
            Console.ReadLine();
        }
        else
        {
            textoAdicional = nome + " Não está acompanhado";
            Console.WriteLine(textoAdicional);
            Console.ReadLine();
        }
    }
}
