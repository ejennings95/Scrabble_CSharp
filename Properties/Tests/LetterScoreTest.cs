using NUnit.Framework;
using Scrabble.Main;
using System;
namespace Scrabble.Properties.Tests
{
    public class LetterScoreTest
    {
        [Test, Description("A should return letterscore 1")]
        public void GetAPoints()
        {
            LetterScore letter = new LetterScore('A');
            Assert.AreEqual(1, letter.GetLetterScore());
        }

        [Test, Description("F should return letterscore 4")]
        public void GetFPoints()
        {
            LetterScore letter = new LetterScore('F');
            Assert.AreEqual(4, letter.GetLetterScore());
        }

        [Test, Description("Z should return letterscore 10")]
        public void GetZPoints()
        {
            LetterScore letter = new LetterScore('Z');
            Assert.AreEqual(10, letter.GetLetterScore());
        }
    }
}
