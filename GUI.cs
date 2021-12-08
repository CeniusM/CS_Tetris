namespace CS_Tetris
{
    class GUI
    {
        private const int Block_Width = 3;
        public string GameName = "";
        private int[] CordOffSet = new int[2];
        private List<List<int>> Board = new List<List<int>>();
        private List<int[]> Cord_Update_List = new List<int[]>();
        public GUI(string AGameName, int x_OffSet, int y_OffSet, List<List<int>> ABord, List<int[]> ACord_Update_List)
        {
            GameName = AGameName;
            if (x_OffSet != 0) CordOffSet[0] = x_OffSet * Block_Width; // times the amount of width in a single square
            else CordOffSet[0] = x_OffSet;
            CordOffSet[1] = y_OffSet;
            Board = ABord;
            Cord_Update_List = ACord_Update_List;
        }
        public void PrintBoard() // prints the whole Board
        {
            for (int i = -1; i <= Board.Count(); i++)
            {
                Console.SetCursorPosition(CordOffSet[0], CordOffSet[1] + i + 1);
                for (int j = -1; j <= Board[0].Count(); j++)
                {
                    PrintField(i, j);
                }
            }
        }
        public void PrintField(int i, int j) // this is supose to print the relevant value for any given field
        {
            // examples "[|]", "[*]", "[-]", "[O]"
            if (i == -1 || j == -1 || i == Board.Count() || j == Board[0].Count()) // Prints the boarders
            {
                ColoredWriter.Write(ConsoleColor.DarkRed, "[-]");
                return;
            }
            else if (Board[i][j] == 0) // prints the background
            {
                // for now, but later print in compareson to the color
                ColoredWriter.Write(ConsoleColor.Gray, "[-]");
            }
            else // prints the fields with any piece / block
            {

            }
        }
        public void PrintUpdates() // only prints the cords from the update list
        {
            foreach (int[] Cords in Cord_Update_List)
            {
                int Cord0 = 0;
                for (int i = 0; i < Cords[0]; i++)
                    Cord0 += Block_Width;
                Console.SetCursorPosition(Cord0, Cords[1]);
                PrintField(Cords[0], Cords[1]);
            }
        }
    }
}