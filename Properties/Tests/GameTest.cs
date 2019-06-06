using NUnit.Framework;
using Scrabble.Main;
using System;
namespace Scrabble.Properties.Tests
{
    public class GameTest
    {
        [Test, Description("Total points is initialised as 0")]
        public void DefaultPoints()
        {
            Game game = new Game();
            Assert.AreEqual(0, game.GetTotalPoints());
        }
    }
}
