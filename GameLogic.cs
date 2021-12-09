namespace CS_Tetris
{
    class GameLogic
    {
        private List<List<int>> Board;
        private Piece Piece;
        private List<int> List_Of_Pieces;
        public GameLogic(List<List<int>> ABoard, Piece APiece, List<int> AList_Of_Pieces)
        {
            Board = ABoard;
            Piece = APiece;
            List_Of_Pieces = AList_Of_Pieces;
        }
        public void RotatePieces(string Rotation)
        {
            if (Rotation != "clockwise" || Rotation != "counterclockwise") // find bedre navne :D
                return;
        }
        public void MovePiece(string Direction)
        {
            if (Direction != "right" || Direction != "left") // find bedre navne :D
                return;
        }
    }
}