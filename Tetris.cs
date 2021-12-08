namespace CS_Tetris
{
    class Tetris
    {
        private const int Amout_Of_Pieces_On_Side = 3;
        private float GameSpeed = 10000;
        private string GameName = "";
        private List<string> Player_Move = new List<string>();
        // list[0] is used to tell if the player input thread is suppose to run
        // I will run 2 threads, one where the gamelogic is running and another one
        // where the player can make wasd/c inputs, and the inputs get send through this list reference
        // this class is used for the player movment
        private List<int> List_Of_Tetris_Pieces = new List<int>();
        private List<List<int>> Board = new List<List<int>>();
        private GUI GUI;
        private List<int[]> CordUpdateList = new List<int[]>();
        private Piece Piece = new Piece(0);
        private int[] X_Piece_Cords = new int[4];
        private int[] Y_Piece_Cords = new int[4];
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