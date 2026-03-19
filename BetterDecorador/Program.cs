using System;

namespace BetterDecorador
{
    public class Program
    {
        private static string Decor(string s, char c, int v)
        {
            string final = "";

            for(int i = 0; i < v; i++)
            {
                final += c;
            }

            final += " ";
            final += s;
            final += " ";

            for(int i = 0; i < v; i++)
            {
                final += c;
            }

            return final;
        }

        private static void Main(string[] args)
        {
            string simbolo = args[1];
            string vezesSimbolo = args[2];

            char simboloChar = char.Parse(simbolo);
            int vezesSimboloInt = int.Parse(vezesSimbolo);

            Console.WriteLine(Decor(args[0],simboloChar,vezesSimboloInt));
        }
    }
}
