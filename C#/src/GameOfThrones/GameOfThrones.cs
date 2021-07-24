using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetHack
{
    // https://www.hackerrank.com/challenges/game-of-thrones/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=7-day-campaign

    public class GameOfThrones
    {
        public string gameOfThrones(string s)
        {
            if (s.Length < 1 || s.Length > Math.Pow(10, 5))
            {
                return "NO";
            }

            if (s.Any(c => Char.IsUpper(c)))
            {
                return "NO";
            }

            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (map.ContainsKey(c))
                {
                    int value = map[c];
                    map[c] = value + 1;
                }
                else
                {
                    map.Add(c, 1);
                }
            }

            StringBuilder firstHalf = new StringBuilder();
            char middleValue = '\0';
            StringBuilder secondHalf = new StringBuilder();

            foreach (KeyValuePair<char, int> item in map)
            {
                if (item.Value == 1 && middleValue != '\0')
                {
                    return "NO";
                }

                if (item.Value == 1)
                {
                    middleValue = item.Key;
                }

                if (item.Value % 2 == 0)
                {
                    int divisor = item.Value / 2;
                    firstHalf.Append(new string(item.Key, divisor));
                    secondHalf.Insert(0, new string(item.Key, divisor));
                }
            }

            string palindrome = $"{firstHalf.ToString()}{middleValue}{secondHalf.ToString()}";

            // reverse palindrome
            char[] charArray = palindrome.ToCharArray();
            Array.Reverse(charArray);
            string reverse = new string(charArray);

            return reverse == palindrome ? "YES" : "NO";
        }

    }
}
