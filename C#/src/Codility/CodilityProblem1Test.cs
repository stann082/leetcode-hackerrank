
using NUnit.Framework;

namespace LeetHack
{
    public class CodilityProblem1Test
    {
        private CodilityProblem1 CodilityProblem1;

        [SetUp]
        public void Setup()
        {
            CodilityProblem1 = new CodilityProblem1();
        }

        [Test]
        public void TestCases()
        {
            // exercise
            string dayOfWeek = CodilityProblem1.solution("wed", 2);

            // post-conditions
            Assert.AreEqual("Fri", dayOfWeek);

            // exercise
            dayOfWeek = CodilityProblem1.solution("sat", 23);

            // post-conditions
            Assert.AreEqual("Mon", dayOfWeek);

            // exercise
            dayOfWeek = CodilityProblem1.solution("sat", 26);

            // post-conditions
            Assert.AreEqual("Thu", dayOfWeek);

            // exercise
            dayOfWeek = CodilityProblem1.solution("Wed", 0);

            // post-conditions
            Assert.AreEqual("Wed", dayOfWeek);

            // exercise
            dayOfWeek = CodilityProblem1.solution("blah", 23);

            // post-conditions
            Assert.IsEmpty(dayOfWeek);

            // exercise
            dayOfWeek = CodilityProblem1.solution(string.Empty, 23);

            // post-conditions
            Assert.IsEmpty(dayOfWeek);

            // exercise
            dayOfWeek = CodilityProblem1.solution("Wed", -1);

            // post-conditions
            Assert.IsEmpty(dayOfWeek);

            // exercise
            dayOfWeek = CodilityProblem1.solution("Wed", 501);

            // post-conditions
            Assert.IsEmpty(dayOfWeek);
        }

    }
}