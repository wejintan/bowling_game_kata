using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowling
{
    class Game
    {
        int[] TempScore = new int[20];
        int index = 0;
        public void SetPins(int p)
        {
            TempScore[index] = p;
            index += 1;
        }


        public int GetFinalScore()
        {
            return TempScore[0] + TempScore[1];
        }
    }
}
