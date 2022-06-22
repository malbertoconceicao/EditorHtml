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
    }
}