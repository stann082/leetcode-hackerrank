
using NUnit.Framework;

namespace LeetHack
{
    public class PalindromeNumberTest
    {
        private PalindromeNumber PalindromeNumber;

        [SetUp]
        public void Setup()
        {
            PalindromeNumber = new PalindromeNumber();
        }

        [Test]
        public void TestCases()
        {
            // exercise
            bool isPalindrome = PalindromeNumber.IsPalindrome(11);

            // post-conditions
            Assert.IsTrue(isPalindrome);

            // exercise
            isPalindrome = PalindromeNumber.IsPalindrome(113);

            // post-conditions
            Assert.IsFalse(isPalindrome);

            // exercise
            isPalindrome = PalindromeNumber.IsPalindrome(1463641);

            // post-conditions
            Assert.IsTrue(isPalindrome);

            // exercise
            isPalindrome = PalindromeNumber.IsPalindrome(2222222);

            // post-conditions
            Assert.IsTrue(isPalindrome);

            // exercise
            isPalindrome = PalindromeNumber.IsPalindrome(5);

            // post-conditions
            Assert.IsTrue(isPalindrome);
        }

    }
}