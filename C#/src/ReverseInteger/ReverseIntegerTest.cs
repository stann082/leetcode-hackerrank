
using NUnit.Framework;

namespace LeetHack
{
    public class ReverseIntegerTest
    {
        private ReverseInteger ReverseInteger;

        [SetUp]
        public void Setup()
        {
            ReverseInteger = new ReverseInteger();
        }

        [Test]
        public void TestCases()
        {
            // exercise
            int stepsRequired = ReverseInteger.Reverse(10);

            // post-conditions
            Assert.AreEqual(1, stepsRequired);

            // exercise
            stepsRequired = ReverseInteger.Reverse(12345);

            // post-conditions
            Assert.AreEqual(54321, stepsRequired);

            // exercise
            stepsRequired = ReverseInteger.Reverse(-4568);

            // post-conditions
            Assert.AreEqual(-8654, stepsRequired);
        }

    }
}