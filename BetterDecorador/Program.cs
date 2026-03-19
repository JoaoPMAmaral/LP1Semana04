using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string texto = args[0];
            string simbolo = args[1];
            string vezesSimbolo = args[2];

            int vezesSimboloInt = int.Parse(vezesSimbolo);

            for(int i = 0; i < vezesSimboloInt; i++)
            {
                Console.Write(simbolo);
            }
            
            Console.Write(" ");
            Console.Write(texto);
            Console.Write(" ");

            for(int i = 0; i < vezesSimboloInt; i++)
            {
                Console.Write(simbolo);
            }
        }
    }
}
