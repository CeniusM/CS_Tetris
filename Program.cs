namespace CS_Tetris // this is my attempt at a tetris that follows the standerd tetris
{
    class Program
    {
        public static void Main()
        {
            Tetris Tetris_Game = new Tetris();

            Tetris_Game.Start();

            Console.ReadLine();
        }
    }
}

/*

ToDoList:

-Make it so you can save the game replay
-Make it so 2 players can play at once
-Make it so you can save a piece to use later

Langt senere*

-Gør sådan istedet for du gemmer replays osv på filer gem dem på databaser som fx MySQL
-Brug databaser til at gemme farve paterns, keybinds osv

*/