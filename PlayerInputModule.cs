namespace CS_Tetris
{
    class Player_Input_Module //: Tetris
    {
        // Tetris Tetris_Game;
        string GameName = "";
        List<string> Player_Move = new List<string>(); // list[0] is used to tell if this thread is suppose to run
        // I will run 2 threads, one where the gamelogic is running and another one
        // where the player can make wasd/c inputs, and the inputs get send through this list reference
        // this class is used for the player movment
        public Player_Input_Module(string AGameName, List<string> APlayer_MoveReference)
        {
            // Tetris_Game = new Tetris();
            Player_Move = APlayer_MoveReference;
            GameName = AGameName;
        }
        private void Logic()
        {
            while (true)
            {
                if (Player_Move[0] == "RUN")
                    PlayerInput();
                else
                    Thread.Sleep(1000);
            }
        }
        private void PlayerInput()
        {
            string key = Console.ReadKey().Key.ToString().ToUpper();
            if (key == "W" || key == "A" || key == "A" || key == "S" || key == "D")
            {
                if (Player_Move[0] == "1")
                    Player_Move[1] = key;
                return;
            }
            else if (key == "P")
            {
                Player_Move[1] = key;
            }
            else return;
        }
    }
}