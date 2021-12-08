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

        }
    }
}