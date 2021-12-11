namespace CS_Tetris
{
    class Piece
    {
        private List<List<int>> Board;
        public int Piece_Type { get; private set; }
        public List<int[]> Piece_Cords = new List<int[]>();
        private GUI GUI;
        public Piece(int APiece_Type, GUI AGUI, List<List<int>> ABoard)
        {
            Board = ABoard;
            GUI = AGUI;
            Piece_Type = APiece_Type;
        }
        public ConsoleColor GetPieceColor()
        {
            return GUI.GetFeildColor(Piece_Cords[0][0], Piece_Cords[0][1]);
        }
        public void SetPieceType(int value)
        {
            Piece_Type = value;
        }
        public void Down() // this is ment to set the piece on lower every time it's called
        {
            bool MoveDown = true;
            // for (int i = 0; i < Piece_Cords.Count; i++)
            // {
            //     for (int j = 0; j < Piece_Cords.Count; j++)
            //     {
            //         if (Board[Piece_Cords[i][0] + 1] != null)
            //         {
            //             if (Piece_Cords[i][0] + 1 == Piece_Cords[j][0] && Piece_Cords[i][1] == Piece_Cords[j][1]) continue; // checks a cord down and on same x axes
            //             else if (Board[Piece_Cords[i][0] + 1][Piece_Cords[i][1]] != 0) MoveDown = false;
            //         }
            //     }
            // }
            if (MoveDown == true)
            {
                for (int i = 0; i < Piece_Cords.Count; i++)
                {
                     Board[Piece_Cords[i][0]][Piece_Cords[i][1]] = 0;
                    Piece_Cords[i][0]++;
                    Board[Piece_Cords[i][0]][Piece_Cords[i][1]] = Piece_Type;
                }
            }
            else StopPiece();
            // Board[Piece_Cords[0][0]][Piece_Cords[0][1] + 10] = 7;
            // Board[Piece_Cords[0][0]][Piece_Cords[0][1]] = 0;
            // Piece_Cords[0][1]++;
            // Board[Piece_Cords[0][0]][Piece_Cords[0][1]] = Piece_Type;
        }
        public void StopPiece() // the method that make the piece stop and make a new one
        {

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
//  ConsoleColor GetPieceColor()
// {
//     switch (Piece_Type)
//     {
//         case 1:
//             return ConsoleColor.DarkBlue;
//         case 2:
//             return ConsoleColor.Green;
//         case 3:
//             return ConsoleColor.DarkYellow;
//         case 4:
//             return ConsoleColor.Blue;
//         case 5:
//             return ConsoleColor.Red;
//         case 6:
//             return ConsoleColor.Yellow;
//         case 7:
//             return ConsoleColor.Magenta;
//         case 0:
//             return ConsoleColor.Gray;
//     }
//     throw new ArgumentException("the piece value must be a number between 0 and 7");
// }