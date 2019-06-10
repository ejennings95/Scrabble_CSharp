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

        [Test, Description("A with double letter bonus should return letterscore 2")]
        public void GetAPointsWithDoubleBonus()
        {
            LetterScore letter = new LetterScore();
            Assert.AreEqual(2, letter.GetLetterScore('A', 2));
        }

        [Test, Description("F with double letter bonus should return letterscore 8")]
        public void GetFPointsWithDoubleBonus()
        {
            LetterScore letter = new LetterScore();
            Assert.AreEqual(8, letter.GetLetterScore('F', 2));
        }

        [Test, Description("Z with triple letter bonus should return letterscore 30")]
        public void GetZPointsWithTripleBonus()
        {
            LetterScore letter = new LetterScore();
            Assert.AreEqual(30, letter.GetLetterScore('Z', 3));
        }
    }
}
