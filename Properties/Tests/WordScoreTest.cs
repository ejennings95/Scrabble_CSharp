using NUnit.Framework;
using Scrabble.Main;
using System;
using System.Collections.Generic;

namespace Scrabble.Tests
{
    public class WordScoreTest
    {
        [Test, Description("GetPoints returns the total of the letterScore list")]
        public void GetPoints()
        {
            WordScore word = new WordScore();
            List<int> letterScore = new List<int>() { 1, 2, 3 };
            Assert.AreEqual(6, word.GetPoints(letterScore));
        }
    }
}
