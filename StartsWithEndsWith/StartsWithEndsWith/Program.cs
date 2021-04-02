using System;

namespace StartsWithEndsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este é um texto de teste";

            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste"));
            Console.WriteLine(texto.EndsWith("XPTO"));
        }
    }
}
