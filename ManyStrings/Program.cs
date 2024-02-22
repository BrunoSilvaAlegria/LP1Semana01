using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        
        {   // String com caracteres de escape

            string str = "Olá, isto é uma plica -> \',\n\tIsto foi um enter e um tab,\ne já agora observe uma barra invertida -> \\";
            Console.WriteLine(str);

            // String com caracteres de Unicode

            string UC = "Um telefone \u260f e uma carta \u2709";        
            Console.WriteLine(UC);

            // String com caracteres de escape e de Unicode

            string frase = "Uma aspa \" e um símbolo de gelo \u2746";
            Console.WriteLine(frase);

        }
    }
}
