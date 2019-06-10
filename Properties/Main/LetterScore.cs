using System;
using System.Collections;
using System.Collections.Generic;

namespace Scrabble.Main
{
    public class LetterScore
    {
        public char thisLetter;
        public int letterScore = 0;
        public Hashtable points = new Hashtable()
        {
            { 'A', 1 },
            { 'B', 3 },
            { 'C', 3 },
            { 'D', 2 },
            { 'E', 1 },
            { 'F', 4 },
            { 'G', 2 },
            { 'H', 4 },
            { 'I', 1 },
            { 'J', 8 },
            { 'K', 5 },
            { 'L', 1 },
            { 'M', 3 },
            { 'N', 1 },
            { 'O', 1 },
            { 'P', 3 },
            { 'Q', 10 },
            { 'R', 1 },
            { 'S', 1 },
            { 'T', 1 },
            { 'U', 1 },
            { 'V', 4 },
            { 'W', 4 },
            { 'X', 8 },
            { 'Y', 4 },
            { 'Z', 10 }
        };

        public LetterScore() { }

        public virtual int GetLetterScore(char letter)
        {
            InputLetterScore(letter);
            return letterScore;
        }

        public virtual int GetLetterScore(char letter, int letterBonus)
        {
            InputLetterScore(letter);
            letterScore = letterScore * letterBonus;
            return letterScore;
        }

        public void InputLetterScore(char letter)
        {
            thisLetter = letter;
            letterScore = Convert.ToInt32(points[thisLetter]);
        }

    }
}
