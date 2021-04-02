using System;
using System.IO;

namespace TextEditor
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
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;

                case 1:
                    Open();
                    break;

                case 2:
                    Edit();
                    break;

                default:
                    Menu();
                    break;
            }
        }

        static void Open()
        {

        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo | Aperte ESC Para sair");
            Console.WriteLine("------------------------------------------------");
            string text = "";

            //para armazenar o texto
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }

            //para sair da edição do texto, aperte ESC
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter (path))
            {
                file.Write(text);
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
}
