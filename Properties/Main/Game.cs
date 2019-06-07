using System;
using System.Collections.Generic;

namespace Scrabble.Main
{
    public class Game
    {
        public int totalPoints = 0;
        public WordScore wordScore = new WordScore();
        public List<int> letterScoreArray = new List<int>();

        public Game()
        {
        }

        public Game(WordScore setupWordScore)
        {
            wordScore = setupWordScore;
        }

        public int GetTotalPoints()
        {
            return totalPoints;
        }

        public void InputTotalPoints()
        {
            totalPoints = wordScore.GetPoints(GetLetterScoreArray());
        }

        public List<int> GetLetterScoreArray()
        {
            return letterScoreArray;
        }

        public void InputLetterScoreArray(List<int> letterScore)
        {
             letterScoreArray = letterScore;
        }
    }
}
