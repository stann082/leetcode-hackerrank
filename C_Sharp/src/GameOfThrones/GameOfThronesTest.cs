
using System;
using NUnit.Framework;

namespace LeetHack
{
    public class GameOfThronesTest
    {
        private GameOfThrones GameOfThrones;

        [SetUp]
        public void Setup()
        {
            GameOfThrones = new GameOfThrones();
        }

        [Test]
        public void TestCases()
        {
            // exercise
            string answer = GameOfThrones.gameOfThrones("cdcdcdcdeeeef");

            // post-conditions
            Assert.AreEqual("YES", answer);

            // exercise
            answer = GameOfThrones.gameOfThrones("cdefghmnopqrstuvw");

            // post-conditions
            Assert.AreEqual("NO", answer);

            // exercise
            answer = GameOfThrones.gameOfThrones("aaabbbb");

            // post-conditions
            Assert.AreEqual("YES", answer);

            // exercise
            answer = GameOfThrones.gameOfThrones("");

            // post-conditions
            Assert.AreEqual("NO", answer);
        }

    }
}