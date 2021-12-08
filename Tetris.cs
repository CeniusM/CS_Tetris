namespace CS_Tetris
{
    class Tetris
    {
        private string GameName = "";
        private List<string> Player_Move = new List<string>();
        // list[0] is used to tell if the player input thread is supose to run
        // i will run 2 threads, one where the gamelogic is running and anotsher one
        // where the player can make wasd/c inputs, and the inputs get send through this list refrence
        private List<List<int>> Board = new List<List<int>>();
        private GUI GUI;
        private List<int[]> CordUpdateList = new List<int[]>();
        private Piece Piece = new Piece(0);
        public Tetris(string AGameName, int x, int y, int x_OffSet, int y_OffSet)
        {
            GameName = AGameName;
            GUI = new GUI(GameName, x_OffSet, y_OffSet, Board, CordUpdateList);
            for (int i = 0; i < x; i++)
            {
                List<int> Line = new List<int>();
                for (int j = 0; j < y; j++)
                {
                    Line.Add(0);
                }
                Board.Add(Line);
            }
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