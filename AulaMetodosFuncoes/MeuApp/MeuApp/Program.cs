using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo();

            string nome = RetornaNome("Nat", "Souza");
            Console.WriteLine(nome);
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal!");
        }

        static string RetornaNome(
            string nome,
            string sobrenome,
            int idade = 36
        )
        {
            return nome + " " + sobrenome + " tem " + idade.ToString();
        }

    }
}
