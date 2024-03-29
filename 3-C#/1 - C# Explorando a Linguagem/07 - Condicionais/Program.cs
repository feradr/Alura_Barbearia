﻿using System;
using System.Security.Cryptography.X509Certificates;

#region Class Pessoa
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}
#endregion

class Programa { 
    static void Main(string[] args)
    {
        #region Modulo Alura
        Console.WriteLine("Executando o projeto 07 - Condicionais \n");

        int idadeJoão = 16;

        if (idadeJoão >= 18) 
        {
            Console.WriteLine("Pode Entrar! \n");
        } else
        {
            Console.WriteLine("Não Pode Entrar! \n");
        }

        Console.WriteLine("Executando o projeto 07 - Condicionais ForEatch \n");
        #endregion

        #region Indo Alem do Modulo
        //Criando Pessoas na Clas para aplicar em um Foreach entrando como Lista
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa() { Nome = "João", Idade = 18 },
            new Pessoa() { Nome = "Leticia", Idade = 16 },
            new Pessoa() { Nome = "Jose", Idade= 37 },
        };

        foreach (var pessoa in pessoas)
        {
            if (pessoa.Idade >= 18)
            {
                Console.WriteLine(pessoa.Nome + " Pode Entrar! \n" ); 
            }
            else
            {
                Console.WriteLine(pessoa.Nome + " Não Pode Entrar! \n");
            }
        }

        Console.WriteLine("Tecle Enter para fechar... ");
        Console.ReadLine();
        #endregion
    }
}