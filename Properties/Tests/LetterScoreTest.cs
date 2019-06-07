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
            LetterScore letter = new LetterScore();
            Assert.AreEqual(1, letter.GetLetterScore('A'));
        }

        [Test, Description("F should return letterscore 4")]
        public void GetFPoints()
        {
            LetterScore letter = new LetterScore();
            Assert.AreEqual(4, letter.GetLetterScore('F'));
        }

        [Test, Description("Z should return letterscore 10")]
        public void GetZPoints()
        {
            LetterScore letter = new LetterScore();
            Assert.AreEqual(10, letter.GetLetterScore('Z'));
        }
    }
}
