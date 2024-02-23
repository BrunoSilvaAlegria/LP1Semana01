using System;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor insira quatro números reais.");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            string str4 = Console.ReadLine();

            Console.WriteLine($"{str1,10:f2}");   
            Console.WriteLine($"{str2,10:f2}"); 
            Console.WriteLine($"{str3,10:f2}"); 
            Console.WriteLine($"{str4,10:f2}");           
        }
    }
}
