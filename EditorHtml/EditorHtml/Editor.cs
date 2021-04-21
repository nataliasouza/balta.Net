using System;
using System.IO;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("--------------------------");
            Console.WriteLine("  Deseja salvar seu arquivo? ");
            Console.WriteLine(" Digite: 1 - Para Salvar | 2 - Voltar ao Menu Principal | 3 - Para Sair ");

            var optionSaveFile = short.Parse(Console.ReadLine());
            MenuSave(optionSaveFile);
        }
        public static void MenuSave(short optionSaveFile)
        {
            switch(optionSaveFile)
            {
                case 1: SaveText(); break;
                case 2: Menu.Show(); break;
                case 3:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
        public static void SaveText(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu.Show();
        }

    }
}