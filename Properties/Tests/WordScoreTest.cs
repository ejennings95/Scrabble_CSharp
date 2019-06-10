using NUnit.Framework;
using Scrabble.Main;
using System;
using System.Collections.Generic;

namespace Scrabble.Tests
{
    public class WordScoreTest
    {
        [Test, Description("GetPoints returns the total of the letterScore list")]
        public void GetPointsNoBonus()
        {
            WordScore word = new WordScore();
            List<int> letterScore = new List<int>() { 1, 2, 3 };
            List<int> wordBonus = new List<int>();
            Assert.AreEqual(6, word.GetPoints(letterScore, wordBonus));
        }

        [Test, Description("GetPoints returns the total of the letterScore list doubled")]
        public void GetPointsOneDoubleBonusScore()
        {
            WordScore word = new WordScore();
            List<int> letterScore = new List<int>() { 1, 2, 3 };
            List<int> wordBonus = new List<int>() { 2 };
            Assert.AreEqual(12, word.GetPoints(letterScore, wordBonus));
        }

        [Test, Description("GetPoints returns the total of the letterScore list doubled, then tripled")]
        public void GetPointsOneDoubleOneTripleBonusScore()
        {
            WordScore word = new WordScore();
            List<int> letterScore = new List<int>() { 1, 2, 3 };
            List<int> wordBonus = new List<int>() { 2, 3 };
            Assert.AreEqual(36, word.GetPoints(letterScore, wordBonus));
        }

        [Test, Description("GetPoints returns the total of the letterScore list tripled, then tripled")]
        public void GetPointsTwoTriplesBonusScore()
        {
            WordScore word = new WordScore();
            List<int> letterScore = new List<int>() { 1, 2, 3 };
            List<int> wordBonus = new List<int>() { 3, 3 };
            Assert.AreEqual(54, word.GetPoints(letterScore, wordBonus));
        }
    }
}
