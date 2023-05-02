using System;

class Programa
{
    static void Main(string[] args)
    {
        char Lista_ASCII = (char)0;

        //for(int i = 0; i <= 127; i++)
        //{
        //    Console.WriteLine(Lista_ASCII);
        //    Lista_ASCII = (char)(Lista_ASCII + 1);
        //}

        for (Lista_ASCII = (char)0; Lista_ASCII <= (char)127; Lista_ASCII++)
        {
            Console.WriteLine(Lista_ASCII);
        }
    }
}