
using NUnit.Framework;

namespace LeetHack
{
    public class AlternatingCharactersTest
    {
        private AlternatingCharacters AlternatingCharacters;

        [SetUp]
        public void Setup()
        {
            AlternatingCharacters = new AlternatingCharacters();
        }

        [Test]
        public void TestCases()
        {
            // exercise
            int minimumDeletions = AlternatingCharacters.alternatingCharacters("AAAA");

            // post-conditions
            Assert.AreEqual(3, minimumDeletions);

            // exercise
            minimumDeletions = AlternatingCharacters.alternatingCharacters("BBBBB");

            // post-conditions
            Assert.AreEqual(4, minimumDeletions);

            // exercise
            minimumDeletions = AlternatingCharacters.alternatingCharacters("ABABABAB");

            // post-conditions
            Assert.AreEqual(0, minimumDeletions);

            // exercise
            minimumDeletions = AlternatingCharacters.alternatingCharacters("BABABA");

            // post-conditions
            Assert.AreEqual(0, minimumDeletions);

            // exercise
            minimumDeletions = AlternatingCharacters.alternatingCharacters("AAABBB");

            // post-conditions
            Assert.AreEqual(4, minimumDeletions);
        }

    }
}