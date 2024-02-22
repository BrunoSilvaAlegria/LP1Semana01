using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        
        {   // Variáveis inteiras com literais adequados
            sbyte num_sb = -69;
            Console.WriteLine($"Valor do tipo sbyte -> {num_sb}");

            short num_shr = 27534;
            Console.WriteLine($"Valor do tipo short -> {num_shr}");

            int num_int = -215;
            Console.WriteLine($"Valor do tipo int -> {num_int}");

            long num_lng = 2611512584356L;
            Console.WriteLine($"Valor do tipo long -> {num_lng}");

            byte num_bt = 7;
            Console.WriteLine($"Valor do tipo byte -> {num_bt}");

            ushort num_ush = 42561;
            Console.WriteLine($"Valor do tipo ushort -> {num_ush}");

            uint num_uint = 211562280U;
            Console.WriteLine($"Valor do tipo uint -> {num_uint}");

            ulong num_ulg = 243562934UL;
            Console.WriteLine($"Valor do tipo ulong -> {num_ulg}");

            char vlr_char = 'f';
            Console.WriteLine($"Valor do tipo char -> {vlr_char}");


            // Variáveis do tipo char com diferentes valores Unicode

            char plane = '\u2708';
            Console.WriteLine($"Valor do tipo char -> {plane}");

            char correct = '\u2714';
            Console.WriteLine($"Valor do tipo char -> {correct}");

            char write = '\u270d';
            Console.WriteLine($"Valor do tipo char -> {write}");


            // Variáveis reais com literais adequados

            float num_flt = 0.0026584f;
            Console.WriteLine($"Valor do tipo float -> {num_flt}");

            double num_dbl = 0.000000000000001;
            Console.WriteLine($"Valor do tipo double -> {num_dbl}");

            decimal num_dcm = 0.00000000000000000000000027m;
            Console.WriteLine($"Valor do tipo float -> {num_dcm}");
        }
    }
}
