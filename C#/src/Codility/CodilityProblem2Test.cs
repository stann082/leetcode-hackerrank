
using NUnit.Framework;

namespace LeetHack
{
    public class CodilityProblem2Test
    {
        private CodilityProblem2 CodilityProblem2;

        [SetUp]
        public void Setup()
        {
            CodilityProblem2 = new CodilityProblem2();
        }

        [Test]
        public void TestCases()
        {
            // exercise
            int maxFamiliesNumber = CodilityProblem2.solution(2, "1A 2F 1C");

            // post-conditions
            Assert.AreEqual(2, maxFamiliesNumber);

            // exercise
            maxFamiliesNumber = CodilityProblem2.solution(1, string.Empty);

            // post-conditions
            Assert.AreEqual(2, maxFamiliesNumber);

            // exercise
            maxFamiliesNumber = CodilityProblem2.solution(2, string.Empty);

            // post-conditions
            Assert.AreEqual(4, maxFamiliesNumber);

            // exercise
            maxFamiliesNumber = CodilityProblem2.solution(2, "1D 1E 2G");

            // post-conditions
            Assert.AreEqual(2, maxFamiliesNumber);

            // exercise
            maxFamiliesNumber = CodilityProblem2.solution(2, "1D 2G");

            // post-conditions
            Assert.AreEqual(2, maxFamiliesNumber);

            // exercise
            maxFamiliesNumber = CodilityProblem2.solution(0, string.Empty);

            // post-conditions
            Assert.AreEqual(0, maxFamiliesNumber);
        }

    }
}