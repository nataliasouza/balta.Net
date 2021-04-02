using System;

namespace ComparacaoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "É apenas um teste";
            Console.WriteLine(texto.CompareTo("É apenas um teste"));
            Console.WriteLine(texto.Contains("Teste"));
            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
        }
    }
}
