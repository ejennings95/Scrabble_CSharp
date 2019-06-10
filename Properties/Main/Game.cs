using System;
using System.Collections.Generic;

namespace Scrabble.Main
{
    public class Game
    {
        public int totalPoints = 0;
        public WordScore wordScore = new WordScore();
        public LetterScore letterScore = new LetterScore();
        public List<int> letterScoreArray = new List<int>();
        public List<char> letterArray = new List<char>();

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

        public void InputTotalPoints(List<int> wordBonuses)
        {
            totalPoints = wordScore.GetPoints(GetLetterScoreArray(), wordBonuses);
        }

        public List<int> GetLetterScoreArray()
        {
            return letterScoreArray;
        }

        public void InputLetterScoreArray(char letter, LetterScore letterScore)
        {
            InputLetterArray(letter);
            letterScoreArray.Add(letterScore.GetLetterScore(letter));
        }

        public void InputLetterScoreArray(char letter, LetterScore letterScore, int letterBonus)
        {
            InputLetterArray(letter);
            letterScoreArray.Add(letterScore.GetLetterScore(letter, letterBonus));
        }

        public List<char> GetLetterArray()
        {
            return letterArray;
        }

        public void InputLetterArray(char letter)
        {
            letterArray.Add(letter);
        }
    }
}
