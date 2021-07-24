
using System;

namespace LeetHack
{
    public class ReverseInteger
    {

        public int Reverse(int x)
        {
            if (x <= Math.Pow(-2, 31) || x >= Math.Pow(2, 31) - 1)
            {
                return 0;
            }

            bool isNegativeNumber = x < 0;
            x = Math.Abs(x);

            string reversedInput = string.Empty;
            string input = x.ToString();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput += input[i];
            }

            if (!int.TryParse(reversedInput, out int result))
            {
                return 0;
            }

            return isNegativeNumber ? result * -1 : result;
        }

    }
}