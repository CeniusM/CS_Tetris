namespace RandomTickSpeed
{
    class RandomTickSpeed
    {
        private List<int> Tick = new List<int>(); // asign each thread or method to a serten tick
        private int Tick_Count = 0;
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