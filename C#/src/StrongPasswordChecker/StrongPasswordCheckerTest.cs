using NUnit.Framework;

namespace LeetHack
{
    public class StrongPasswordCheckerTest
    {
        private StrongPasswordChecker PassCheck;

        [SetUp]
        public void Setup()
        {
            PassCheck = new StrongPasswordChecker();
        }

        [Test]
        public void TestCases()
        {
            // exercise
            int stepsRequired = PassCheck.StrongPasswordCheck("a");

            // post-conditions
            Assert.AreEqual(5, stepsRequired);

            // exercise
            stepsRequired = PassCheck.StrongPasswordCheck("aA1");

            // post-conditions
            Assert.AreEqual(3, stepsRequired);

            // exercise
            stepsRequired = PassCheck.StrongPasswordCheck("1337C0d3");

            // post-conditions
            Assert.AreEqual(0, stepsRequired);

            // exercise
            stepsRequired = PassCheck.StrongPasswordCheck("aaa1337C0d3");

            // post-conditions
            Assert.AreEqual(1, stepsRequired);
        }

    }
}