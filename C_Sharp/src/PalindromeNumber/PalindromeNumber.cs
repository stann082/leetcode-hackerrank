using System;

namespace LeetHack
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < Math.Pow(-2, 31) || x > Math.Pow(2, 31) - 1)
            {
                return false;
            }

            string numberValue = x.ToString();
            int numberLength = numberValue.Length;
            bool isEvenNumber = numberLength % 2 == 0;

            int halfCharactersLength;
            string firstHalf;
            string secondHalf;

            if (isEvenNumber)
            {
                halfCharactersLength = numberLength / 2;
                firstHalf = numberValue.Substring(0, halfCharactersLength);
                secondHalf = numberValue.Substring(halfCharactersLength);
            }
            else
            {
                halfCharactersLength = (numberLength - 1) / 2;
                firstHalf = numberValue.Substring(0, halfCharactersLength);
                secondHalf = numberValue.Substring(halfCharactersLength + 1);
            }

            int j = secondHalf.Length - 1;

            for (int i = 0; i < firstHalf.Length; i++)
            {
                if (j < 0)
                {
                    return false;
                }

                char firstHalfChar = firstHalf[i];
                char secondHalfChar = secondHalf[j];
                if (firstHalfChar != secondHalfChar)
                {
                    return false;
                }

                j--;
            }

            return true;
        }

    }
}