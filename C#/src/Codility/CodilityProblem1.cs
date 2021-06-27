using System;
using System.Linq;

namespace LeetHack
{
    public class CodilityProblem1
    {

        public string solution(string dayOfWeek, int daysAfter)
        {
            if (daysAfter < 0 || daysAfter > 500)
            {
                return string.Empty;
            }

            string[] daysOfWeek = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            string selectedDay = daysOfWeek.FirstOrDefault(dow => string.Equals(dow, dayOfWeek, StringComparison.CurrentCultureIgnoreCase));
            if (string.IsNullOrEmpty(selectedDay))
            {
                return string.Empty;
            }

            int indexOfSelectedDay = Array.IndexOf(daysOfWeek, selectedDay);
            int daysToSkip = indexOfSelectedDay + daysAfter;
            return GetDayOfWeek(daysToSkip, daysOfWeek);
        }

        private string GetDayOfWeek(int daysToSkip, string[] daysOfWeek)
        {
            int lastIndex = daysOfWeek.Length - 1;
            if (daysToSkip <= lastIndex)
            {
                return daysOfWeek[daysToSkip];
            }

            int crossThresholdDays = daysToSkip - lastIndex;
            return GetDayOfWeek(crossThresholdDays - 1, daysOfWeek);
        }
    }

}
