namespace CS_Tetris
{
    class Piece
    {
        private int Piece_Type;
        private List<int[]> Piece_Cords = new List<int[]>();
        public Piece(int APiece_Type)
        {
            Piece_Type = APiece_Type;
        }
        public ConsoleColor GetPeiceColor()
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
            throw new ArgumentException("the peice value must be a number between 0 and 7");
        }
    }
}

/*

The peice types and colors and so on

0 = "" = none

1 = L = DarkBlue
[]
[]
[][]

2 = S = Green
  [][]
[][]

3 = J = Orenge
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

7 = T = purple
  []
[][][]

*/