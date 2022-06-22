using System;

namespace EditorHtml 
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            
            DrawScreem();
            WriteOption();
            
            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }
        public static void DrawScreem()
        {
            Console.Clear();
            Separador(30);
            LinhaColuna(10,30);
            Separador(30);
            }
        public static void Separador(int separador)
        {
            Console.Write("+");

            for(int i = 0; i <= separador; i++)
                Console.Write("-");
            
            Console.Write("+");
            Console.Write("\n");
        }
        public static void LinhaColuna(int linhas, int colunas)
        {
            for (int lines = 0; lines <= linhas; lines++)
            {
                Console.Write("|");
                for(int i = 0; i <= colunas; i++)
                    Console.Write(" ");
                
                Console.Write("|");
                Console.Write("\n");
            }
        }
        public static void WriteOption()
        {
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção: ");
        
        }
        public static void HandleMenuOption(short option)
        {
            switch(option)
            {
                case 1: Console.WriteLine("Editor"); break;
                case 2: Console.WriteLine("Abrir"); break;
                case 0: 
                {
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                }
            }
        }
    }
}