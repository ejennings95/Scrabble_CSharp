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

        [Test, Description("GetLetterScoreArray will store letters in letterArray")]
        public void LetterArray()
        {
            LetterScore letterScore = Mock.Of<LetterScore>();
            char letter1 = 'A';
            char letter2 = 'B';
            Game game = new Game();
            Mock.Get(letterScore).Setup(s => s.GetLetterScore(letter1));
            Mock.Get(letterScore).Setup(s => s.GetLetterScore(letter2));
            game.InputLetterScoreArray(letter1, letterScore);
            game.InputLetterScoreArray(letter2, letterScore);
            Assert.AreEqual('A', game.GetLetterArray()[0]);
            Assert.AreEqual('B', game.GetLetterArray()[1]);
            Assert.AreEqual(2, game.GetLetterArray().Count);
        }

        [Test, Description("GetLetterScoreArray will return 1, 10 when A, Z are inputted")]
        public void GetLetterScoreArray()
        {
            LetterScore letterScore = Mock.Of<LetterScore>();
            char letter1 = 'A';
            char letter2 = 'Z';
            Game game = new Game();
            Mock.Get(letterScore).Setup(s => s.GetLetterScore(letter1)).Returns(1);
            Mock.Get(letterScore).Setup(s => s.GetLetterScore(letter2)).Returns(10);
            game.InputLetterScoreArray(letter1, letterScore);
            game.InputLetterScoreArray(letter2, letterScore);
            Assert.AreEqual(10, game.GetLetterScoreArray()[1]);
            Assert.AreEqual(1, game.GetLetterScoreArray()[0]);
            Assert.AreEqual(2, game.GetLetterScoreArray().Count);
        }

        [Test, Description("GetLetterScoreArray will return 2, 30 when A (with double letter bonus), Z (with triple letter bonus) are inputted")]
        public void GetLetterScoreArrayWithLetterBonuses()
        {
            LetterScore letterScore = Mock.Of<LetterScore>();
            char letter1 = 'A';
            char letter2 = 'Z';
            int doubleBonus = 2;
            int tripleBonus = 3;
            Game game = new Game();
            Mock.Get(letterScore).Setup(s => s.GetLetterScore(letter1, doubleBonus)).Returns(2);
            Mock.Get(letterScore).Setup(s => s.GetLetterScore(letter2, tripleBonus)).Returns(30);
            game.InputLetterScoreArray(letter1, letterScore, doubleBonus);
            game.InputLetterScoreArray(letter2, letterScore, tripleBonus);
            Assert.AreEqual(30, game.GetLetterScoreArray()[1]);
            Assert.AreEqual(2, game.GetLetterScoreArray()[0]);
            Assert.AreEqual(2, game.GetLetterScoreArray().Count);
        }
    }
}
