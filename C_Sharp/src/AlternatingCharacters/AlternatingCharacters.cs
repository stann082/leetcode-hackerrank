using System;

namespace LeetHack
{
    // https://www.hackerrank.com/challenges/alternating-characters/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign

    public class AlternatingCharacters
    {
        public int alternatingCharacters(string s)
        {
            string allowedLetters = "AB";
            foreach (char c in s)
            {
                if (!allowedLetters.Contains(c.ToString()))
                {
                    return 0;
                }
            }

            if (string.IsNullOrEmpty(s) || s.Length > Math.Pow(10, 5))
            {
                return 0;
            }

            int charactersToDelete = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char currentCharacter = s[i];
                if (i == 0)
                {
                    continue;
                }

                char previousCharacter = s[i - 1];
                if (currentCharacter == previousCharacter)
                {
                    charactersToDelete++;
                }
            }

            return charactersToDelete;
        }

    }
}
