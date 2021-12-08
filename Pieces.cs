namespace CS_Tetris
{
    class Piece
    {
        public int Piece_Type { get; private set; }
        private List<int[]> Piece_Cords = new List<int[]>();
        public Piece(int APiece_Type)
        {
            Piece_Type = APiece_Type;
        }
        public ConsoleColor GetPieceColor()
        {
            switch (Piece_Type)
            {
                case 1:
                    return ConsoleColor.DarkBlue;
                case 2:
                    return ConsoleColor.Green;
                case 3:
                    return ConsoleColor.DarkYellow;
                case 4:
                    return ConsoleColor.Blue;
                case 5:
                    return ConsoleColor.Red;
                case 6:
                    return ConsoleColor.Yellow;
                case 7:
                    return ConsoleColor.Magenta;
                case 0:
                    return ConsoleColor.Gray;
            }
            throw new ArgumentException("the piece value must be a number between 0 and 7");
        }
        public void SetPieceType(int value)
        {
            Piece_Type = value;
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