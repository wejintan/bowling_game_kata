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
        int count = 0;
        int finscore = 0;
        public void SetPins(int p)
        {
         
                TempScore[index] = p;
                index += 1;
        }


        public int GetFinalScore()
        {
            for (int k = 0; k<index; k++ )
            {
                if (TempScore[k] == 10)
                {
                       finscore += TempScore[k];
                       finscore += TempScore[k+1];
                       finscore += TempScore[k+2];
                       count = 0;
                }
                else
                {

                    if(count==1 && TempScore[k]+TempScore[k+1]==10)
                    {
                        finscore += TempScore[k];
                        finscore += TempScore[k + 1];
                        finscore += TempScore[k + 2];
                        count = 0;
                    }
                    else
                    {
                        finscore += TempScore[k];
                    }


                    if (count == 0)
                    {
                        count += 1;
                    }
                    else
                    {
                        count = 0;
                    }
                }
               
            }
                return finscore;
        }
    }
}
