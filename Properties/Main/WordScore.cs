using System;
using System.Collections.Generic;

namespace Scrabble.Main
{
    public class WordScore
    {
        public int points = 0;

        public WordScore()
        {
        }

        public virtual int GetPoints(List<int> letterPoints)
        {
            InputPoints(letterPoints);
            return points;
        }

        public void InputPoints(List<int> letterPoints)
        {
            var count = 0;
            while (count < letterPoints.Count)
            {
                points += letterPoints[count];
                count++;
            }
        }
    }
}

