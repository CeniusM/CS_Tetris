namespace CS_Tetris
{
    class Program
    {
        public static void Main()
        {
            Tetris Tetris_Game = new Tetris("AGame", 10, 20, 0, 0);

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