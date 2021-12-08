namespace CS_Tetris
{
    class GUI
    {
        public string GameName = "";
        private int[] CordOffSet = new int[2];
        private List<List<int>> Board = new List<List<int>>();
        private List<int[]> CordUpdateList = new List<int[]>();
        public GUI(string AGameName, int x_OffSet, int y_OffSet, List<List<int>> ABord, List<int[]> ACordUpdateList)
        {
            GameName = AGameName;
            CordOffSet[0] = x_OffSet;
            CordOffSet[1]= y_OffSet;
            Board = ABord;
            CordUpdateList = ACordUpdateList;
        }
        public void PrintBoard()
        {
            Console.SetBufferSize(CordOffSet[0], CordOffSet[1]);
            for (int i = -1; i < Board.Count()+1; i++)
            {
                for (int j = -1; j < Board[0].Count()+1; j++)
                {
                    PrintField(i,j);
                }
            }
        }
        public void PrintField(int i, int j)
        {
            if (i == -1 || j == -1)
            {
                ColoredWriter.Write(ConsoleColor.Gray, "[]");
                return;
            }
            else if (i == Board.Count() || j == Board[0].Count())
            {
                ColoredWriter.Write(ConsoleColor.Gray, "[]");
                return;
            }
            else if (Board[i][j] == 0)
            {
                
            }
        }
        public void PrintUpdates()
        {

        }
    }
}