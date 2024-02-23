using System;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedido dos 4 números reais
            Console.WriteLine("Por favor insira quatro números reais."); 
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            string str4 = Console.ReadLine();

            // Conversão das strings para número real(float)
            float num1 = float.Parse(str1);
            float num2 = float.Parse(str2);
            float num3 = float.Parse(str3);
            float num4 = float.Parse(str4);

            // Impressão dos valores com alinhamento à direita
            // e com duas casas decimais
            Console.WriteLine($"{num1,10:f2}");   
            Console.WriteLine($"{num2,10:f2}"); 
            Console.WriteLine($"{num3,10:f2}"); 
            Console.WriteLine($"{num4,10:f2}");           
        }
    }
}
