using System;

namespace MetodosAdicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Um texto de exemplo";
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.Insert(8, " AQUI"));
            Console.WriteLine(texto.Remove(3,5));
            Console.WriteLine(texto.Length);
        }
    }
}
