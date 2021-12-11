namespace CS_Tetris
{
    class NextPiece
    {
        private List<List<int>> Board;
        private Piece Piece;
        private List<int> List_Of_Pieces;
        private GUI GUI;
        public NextPiece(List<List<int>> ABoard, Piece APiece, List<int> AList_Of_Pieces, GUI AGUI)
        {
            GUI = AGUI;
            Board = ABoard;
            Piece = APiece;
            List_Of_Pieces = AList_Of_Pieces;
        }
        public void AddToList()
        {
            List_Of_Pieces.Add(GetRandomPieceType());
        }
        private int GetRandomPieceType()
        {
            Random rnd = new Random();

            return rnd.Next(1, 8);
        }
        public void New()
        {
            // Piece = new Piece(List_Of_Pieces[0], GUI, Board);
            List_Of_Pieces.RemoveAt(0);
            List_Of_Pieces.Add(GetRandomPieceType());
            List<int[]> ListOfCords = GetPieceCords(List_Of_Pieces[0]);
            Piece.Piece_Cords = new List<int[]>();
            for (int i = 0; i < ListOfCords.Count; i++)
            {
                Piece.Piece_Cords.Add(new int[2]);
                Piece.Piece_Cords[i][0] = ListOfCords[i][0] + (Board[0].Count / 2);
                Piece.Piece_Cords[i][1] = ListOfCords[i][1];
            }
            foreach (int[] Cords in ListOfCords)
            {
                Board[Cords[0]][Cords[1] + (Board[0].Count / 2 - 1)] = List_Of_Pieces[0];
            }
        }
        private List<int[]> GetPieceCords(int Piece_Type)
        {
            List<int[]> List_Of_Cords = new List<int[]>();
            void AddCord(int x, int y)
            {
                int[] cord = { x, y };
                List_Of_Cords.Add(cord);
            }
            AddCord(0, 0);
            switch (Piece_Type)
            {
                case 1:
                    AddCord(1, 0);
                    AddCord(2, 0);
                    AddCord(2, 1);
                    return List_Of_Cords;
                case 2:
                    AddCord(0, 1);
                    AddCord(1, 0);
                    AddCord(1, -1);
                    return List_Of_Cords;
                case 3:
                    AddCord(1, 0);
                    AddCord(2, 0);
                    AddCord(2, -1);
                    return List_Of_Cords;
                case 4:
                    AddCord(1, 0);
                    AddCord(2, 0);
                    AddCord(3, 0);
                    return List_Of_Cords;
                case 5:
                    AddCord(0, -1);
                    AddCord(1, 0);
                    AddCord(1, 1);
                    return List_Of_Cords;
                case 6:
                    AddCord(1, 1);
                    AddCord(1, 0);
                    AddCord(0, 1);
                    return List_Of_Cords;
                case 7:
                    AddCord(1, 0);
                    AddCord(1, 1);
                    AddCord(1, -1);
                    return List_Of_Cords;
            }
            throw new ArgumentException("the type value is invalid");
        }
    }
}

/*

The piece types and colors and so on

0 = "" = Gray/None

1 = L = DarkBlue
  []
  []
  [][]

2 = S = Green
  [][]
[][]

3 = J = Orange
  []
  []
[][]

4 = I = LighterBlue
  []
  []
  []
  []

5 = Z = Red
[][]
  [][]

6 = O = Yellow
  [][]
  [][]

7 = T = Purple
  []
[][][]

*/