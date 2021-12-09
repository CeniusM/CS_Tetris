namespace CS_Tetris
{
    // public class DispatcherTimer:DispatcherTimer{}
    class Tetris
    {
        private List<int> Tick = new List<int>(); // asign each thread or method to a serten tick
        private int Tick_Count = 0;
        private string GameName = "";
        private int Points = 0;
        private const int Amout_Of_Pieces_On_Side = 3;
        private float GameSpeed = 10000;
        // lav en second thread 
        //som der lige så stille holder øje med scoren mens den sætte dette op, husk og lav en minimum
        private List<string> Player_Move = new List<string>(2);
        // list[0] is used to tell if the player input thread is suppose to run, "1" = run
        // I will run 2 threads, one where the gamelogic is running and another one
        // where the player can make wasd/c inputs, and the inputs get send through this list reference
        // this class is used for the player movment
        private List<int> List_Of_Tetris_Pieces = new List<int>();
        private List<List<int>> Board = new List<List<int>>();
        private GUI GUI;
        private NextPiece NextPiece;
        private List<int[]> CordUpdateList = new List<int[]>();
        private Piece Piece;
        private int[] X_Piece_Cords = new int[4];
        private int[] Y_Piece_Cords = new int[4];
        private GameLogic GameLogic;
        public Tetris(string AGameName, int x, int y, int x_OffSet, int y_OffSet, int Amount_Of_Pieces_On_Side)
        {
            if (Amount_Of_Pieces_On_Side < 1) throw new Exception("This needs to be more then 0");
            GameName = AGameName;
            GUI = new GUI(GameName, x_OffSet, y_OffSet, Board, CordUpdateList);
            Piece = new Piece(0, GUI, Board);
            GameLogic = new GameLogic(Board, Piece, List_Of_Tetris_Pieces);
            NextPiece = new NextPiece(Board, Piece, List_Of_Tetris_Pieces, GUI);
            for (int i = 0; i < Amount_Of_Pieces_On_Side; i++)
            {
                NextPiece.AddToList();
            }
            for (int i = 0; i < y; i++)
            {
                List<int> Line = new List<int>();
                for (int j = 0; j < x; j++)
                {
                    Line.Add(0);
                }
                Board.Add(Line);
            }
        }
        public void Start()
        {
            SetUp();

            Play();

            //test
            GUI.PrintBoard();
        }
        private void Play()
        {

        }
        private void SetUp()
        {
            // inport settings

            GUI.SetUpConsole();

            //test
            NextPiece.New();
            Piece.Down();
            Piece.Down();
            Piece.Down();
            Piece.Down();
            NextPiece.New();
        }
        private void PlayerMove() // tick 1
        {
            while (true)
            {
                if (Player_Move[1] == "A")
                {
                    GameLogic.MovePiece("left");
                }
                if (Player_Move[1] == "D")
                {
                    GameLogic.MovePiece("right");
                }


                //tick operation
                while (true)
                {
                    if (Tick[1] == 1)
                    {
                        Tick[1] = 0;
                        break;
                    }
                }
            }
        }
        private void GameTick()
        {

        }

        private void TickSpeed(int Ms) // only update the stuff that needs to be updated each second
        {
            while (true) // while game is running
            {
                for (int i = 0; i < Tick.Count(); i++)
                    Tick[i]++;
                Tick_Count++;
                GameTick();
                Thread.Sleep(Ms);
            }
        } // also have 2 difrent ticks for player move and game move
    }
}