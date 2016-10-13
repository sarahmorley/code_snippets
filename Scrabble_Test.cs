using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore; 

namespace ScrabbleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCorrectScoreforWord()
        {
            int score = 8;
            int wordScore = Scrabble.GetLetterPoints("hello");
            Assert.AreEqual(score, wordScore);
        }

        [TestMethod]
        public void TestCorrectScoreforLetter()
        {       
            int score = 10;
            int wordScore = Scrabble.GetLetterPoints("z");
            Assert.AreEqual(score, wordScore);
        }

        [TestMethod]
        public void TestEmptyWordScoresZero()
        {
            string empty = "";
            int score = 0;
            int wordScore = Scrabble.GetLetterPoints(empty);
            Assert.AreEqual(score, wordScore);
        }



    }
}
