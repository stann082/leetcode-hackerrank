using NUnit.Framework;
using System.Collections.Generic;

namespace LeetHack
{
    public class Challenge1Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCases()
        {
            // exercise
            List<long> spots = new List<long>(new long[] { 2, 10, 8, 17 });
            long length = Challenge1.carParkingRoof(spots, 3);

            // post-conditions
            Assert.AreEqual(9, length);

            // exercise
            spots = new List<long>(new long[] { 2, 10, 8, 17, 13 });
            length = Challenge1.carParkingRoof(spots, 3);

            // post-conditions
            Assert.AreEqual(6, length);

            // exercise
            spots = new List<long>(new long[] { 1, 2, 3, 10 });
            length = Challenge1.carParkingRoof(spots, 4);

            // post-conditions
            Assert.AreEqual(10, length);

            // exercise
            spots = new List<long>(new long[] { 2, 10, 8, 17, 13, 11 });
            length = Challenge1.carParkingRoof(spots, 3);

            // post-conditions
            Assert.AreEqual(4, length);

            // exercise
            spots = new List<long>(new long[] { 2, 2, 8, 17 });
            length = Challenge1.carParkingRoof(spots, 3);

            // post-conditions
            Assert.AreEqual(0, length);

            // exercise
            spots = new List<long>(new long[] { 2, 3, 8, 17 });
            length = Challenge1.carParkingRoof(spots, 5);

            // post-conditions
            Assert.AreEqual(0, length);
        }

    }
}