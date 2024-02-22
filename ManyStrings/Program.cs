using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        
        {   // Formatação de valores

            double xx = 1.23456;
            int ii = 19;

            string s1 = $"Número real com duas casas decimais: {xx:f2}";
            string s2 = $"Percentagem com uma casa decimal: {xx:p1}";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            
            string s3 = $"O valor hexadecimal de {ii} é {ii:x}";
            string s4 = $"O valor em moeda de {ii} é {ii:c}";
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            
            // String com caracteres de escape

            string str = "Olá, isto é uma plica -> \',\n\tIsto foi um enter e um tab,\ne já agora observe uma barra invertida -> \\";
            Console.WriteLine(str);

            // String com caracteres de Unicode

            string UC = "Um telefone \u260f e uma carta \u2709";        
            Console.WriteLine(UC);

            // String com caracteres de escape e de Unicode

            string frase = "Uma aspa \" e um símbolo de gelo \u2746";
            Console.WriteLine(frase);


            // Strings concatenadas

            string c1 = "a";
            int c2 = 2;
            string c3 = c1 + c2;
            Console.WriteLine(c3);

            float c4 = 3.333f;
            string c5 = "\u2573";
            string c6 = "Junção" + " de várias " + "strings: " + c4 + c5;
            Console.WriteLine(c6);

            c6 += c3;
            Console.WriteLine(c6);

            // Strings interpoladas

            string nova = $"O valor de um float é {c4} e de um int é {c2}";
            string nv_str = $"{c2} + {c4} é igual a {c2+c4}";
            Console.WriteLine(nova);
            Console.WriteLine(nv_str);
        }
    }
}
