using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// grabs 3 arguments from user and returns a string
        /// </summary>
        /// <param name="s">string in between decorations</param>
        /// <param name="c">character for decorating before and after</param>
        /// <param name="v">number of times character is repeated</param>
        /// <returns>a final string from the addition of everything</returns>
        private static string Decor(string s, char c, int v)
        {
            string final = "";
         
            if(s.Length == 0)
            {
                final += "User did not specify args";
            }

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

        /// <summary>
        /// calls decor and user's parameters
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            if(args.Length != 0)
            {
                string simbolo = args[1];
                string vezesSimbolo = args[2];

                char simboloChar = char.Parse(simbolo);
                int vezesSimboloInt = int.Parse(vezesSimbolo);

                Console.WriteLine(Decor(args[0],simboloChar,vezesSimboloInt));
            }
            else
            {
                Console.WriteLine(Decor("User did not specify args!",'=',3));
            }
        }
    }
}