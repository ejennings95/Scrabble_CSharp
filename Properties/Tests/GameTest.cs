using Moq;
using NUnit.Framework;
using Scrabble.Main;
using System;
using System.Collections.Generic;

namespace Scrabble.Tests
{
    public class GameTest
    {
        [Test, Description("Total points is initialised as 0")]
        public void DefaultPoints()
        {
            Game game = new Game();
            Assert.AreEqual(0, game.GetTotalPoints());
        }

        [Test, Description("InputTotalPoints sets the TotalPoints to the return value of WordScore.GetPoints")]
        public void InputTotalPoints()
        {
            List<int> letterPoints = new List<int>();
            WordScore wordScore = Mock.Of<WordScore>();
            Game game = new Game(wordScore);
            Mock.Get(wordScore).Setup(s => s.GetPoints(letterPoints)).Returns(7);
            game.InputTotalPoints();
            Assert.AreEqual(7, game.GetTotalPoints());
        }
    }
}
