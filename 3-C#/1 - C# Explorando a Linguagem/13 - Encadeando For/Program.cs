﻿using System;
using System.IO.Pipes;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 13 - Encadeando For");

        //Usando Break
        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
            {
                Console.Write("*");
                if (contadorColunas >= contadorLinhas)
                {
                    break;
                }
            }
                Console.WriteLine();
        }


        //Não usando Break
        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}