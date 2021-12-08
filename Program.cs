namespace CS_Tetris
{
    class Program
    {
        public static void Main()
        {
            Tetris Tetris_Game = new Tetris("AGame", 10, 20, 0, 0);

            Tetris_Game.Start();
        }
    }
}

/*

ToDoList:

-Make it so you can save the game replay
-Make it so 2 players can play at once
-Make the saving one piece thingy

*/