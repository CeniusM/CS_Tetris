namespace CS_Tetris
{
    class Player_Input_Module
    {
        string GameName = "";
        List<string> Player_Move = new List<string>(); // list[0] is used to tell if this thread is supose to run
        // i will run 2 threads, one where the gamelogic is running and anotsher one
        // where the player can make wasd/c inputs, and the inputs get send through this list refrence
        // this class is used for the player movment
        public Player_Input_Module(string AGameName, List<string> APlayer_MoveRefrence)
        {
            Player_Move = APlayer_MoveRefrence;
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

        }
    }
}