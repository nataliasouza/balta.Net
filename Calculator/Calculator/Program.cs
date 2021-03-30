using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("======== CALCULADORA ========\n");
            Console.WriteLine("ESCOLHA UMA OPÇÃO: \n");
            Console.WriteLine("Digite 1 - Para Somar");
            Console.WriteLine("Digite 2 - Para Subtração");
            Console.WriteLine("Digite 3 - Para Divisão");
            Console.WriteLine("Digite 4 - Para Multiplicação");
            Console.WriteLine("Digite 5 - Para Sair\n");
            Console.WriteLine("=============================\n");

            Console.Write("Digite a opção: ");
            short res = short.Parse(Console.ReadLine());
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            //Formas de mostrar os resultados 
            //Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é: { resultado}");
            //Console.WriteLine($"O resultado da soma é: {v1 + v2}");
            //Console.WriteLine("O resultado da soma é: " + (v1 + v2)); 
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}" );
            Console.ReadKey();
        } 

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1/v2;

            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();
        }
    }
}
