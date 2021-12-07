namespace CS_Tetris
{
    class Tetris
    {
        string GameName = "";
        List<string> Player_Move = new List<string>();
        // i will run 2 threads, one where the gamelogic is running and another one
        // where the player can make wasd/c inputs, and the inputs get send through this list refrence
        public Tetris(string AGameName = "AGame")
        {
            GameName = AGameName;
        }
        public void Start()
        {

        }
        private void Play()
        {

        }
        private void SetUp()
        {

        }
    }
}