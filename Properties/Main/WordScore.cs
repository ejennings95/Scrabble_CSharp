using System;
using System.Collections.Generic;

namespace Scrabble.Main
{
    public class WordScore
    {
        public int points = 0;
        public List<int> wordBonuses = new List<int>();

        public WordScore()
        {
        }

        public virtual int GetPoints(List<int> letterPoints, List<int> wordBonuses)
        {
            InputPoints(letterPoints);
            BonusCheck(wordBonuses);
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

        public void BonusCheck(List<int> wordBonuses)
        {
            if (wordBonuses.Count >= 0)
            {
                var count = 0;
                while (count < wordBonuses.Count)
                {
                    points = points * wordBonuses[count];
                    count++;
                }
            }
        }
    }
}

