namespace CS_Tetris
{
    class GameLogic
    {
        public int GetRandomPieceType()
        {
            Random rnd = new Random();

            return rnd.Next(1, 8);
        }
    }
}