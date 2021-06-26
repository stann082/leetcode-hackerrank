using System.Linq;

namespace LeetHack
{
    public class StrongPasswordChecker
    {
        public int StrongPasswordCheck(string password)
        {
            int steps = 5;

            char[] passwordCharacters = password.ToCharArray();
            if (passwordCharacters.Length <= 1 || passwordCharacters.Length > 50)
            {
                return steps;
            }

            if (passwordCharacters.Length >= 6 && passwordCharacters.Length <= 20)
            {
                steps -= 1;
            }

            if (passwordCharacters.Any(c => char.IsDigit(c)))
            {
                steps -= 1;
            }

            if (passwordCharacters.Any(c => char.IsLower(c)))
            {
                steps -= 1;
            }

            if (passwordCharacters.Any(c => char.IsUpper(c)))
            {
                steps -= 1;
            }

            if (passwordCharacters.Length > 3)
            {
                bool hasThreeConsecutiveChars = passwordCharacters.Where((c, i) => i >= 2 && passwordCharacters[i - 1] == c && passwordCharacters[i - 2] == c).Any();
                if (!hasThreeConsecutiveChars)
                {
                    steps -= 1;
                }
            }

            return steps;
        }

    }
}