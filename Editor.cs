using System;
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
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("===========");

            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();
            {
                do 
                {
                    file.Append(Console.ReadLine());
                    file.Append(Environment.NewLine);
                } while (Console.ReadKey().Key != ConsoleKey.Escape);

                Console.WriteLine("----------");
                Console.WriteLine("  Deseja Salvar o arquivo?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");

                var option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1: {
                        Console.WriteLine("Qual caminho deseja salvar?");
                        var path = Console.ReadLine();
                        Salvar(file.ToString(), path);
                        Console.WriteLine($"Arquivos salvo em {path}com sucesso!!!");
                        Thread.Sleep(1000);                      
                        break;
                    }
                    case 2: System.Environment.Exit(0);break;
                    default: Start(); break;
                }

                    Viewer.Show(file.ToString());
                    
            }
            static void Salvar(string file, string path)
            {
                using ( var arquivo = new StreamWriter(path))
                {
                    arquivo.Write(file);
                }
            }
        }
    }
}