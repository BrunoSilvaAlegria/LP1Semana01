﻿using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input de strings pelo utilizador e conversão para valores

            Console.WriteLine("Por favor insira um número inteiro.");
            string str1 = Console.ReadLine();
            int inteiro = int.Parse(str1);
            
            Console.WriteLine("Por favor insira um número real.");
            string str2 = Console.ReadLine();
            float num = float.Parse(str2);

            Console.WriteLine($"Resultado da soma dos valores:{inteiro + num}");


        

        }
    }
}