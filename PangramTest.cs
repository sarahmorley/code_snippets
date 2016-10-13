using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pangram; 

namespace PangramTest
{
    [TestClass]
    public class PangramTest
    {
        [TestMethod]
        public void TestTruePangram()
        {
            string sentence = "the quick brown fox jumps over the lazy dog";
            bool expectedResult = true;
            bool result = Pangram.Pangram.CheckPangram(sentence);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestFalsePangram()
        {
            string sentence = "the quick brown fox jumps";
            bool expectedResult = false;
            bool result = Pangram.Pangram.CheckPangram(sentence);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestEmptyString()
        {
            string sentence = "";
            bool expectedResult = false;
            bool result = Pangram.Pangram.CheckPangram(sentence);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestTruePangramWithNumbers()
        {
            string sentence = "the quick brown fox jumps over the 12 lazy dogs";
            bool expectedResult = true;
            bool result = Pangram.Pangram.CheckPangram(sentence);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
