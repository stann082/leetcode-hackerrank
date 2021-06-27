using System;
using System.Linq;

namespace LeetHack
{
    public class CodilityProblem2
    {

        public int solution(int rows, string reservedSeatsValue)
        {
            if (rows < 1 || rows > 50)
            {
                return 0;
            }

            if (reservedSeatsValue.Length > 1909)
            {
                return 0;
            }

            string[] seats = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "J", "K" };
            string[,] seatMap = new string[rows, seats.Length];

            string[] reservedSeats = !string.IsNullOrEmpty(reservedSeatsValue) ? reservedSeatsValue.Split(' ') : new string[0];
            foreach (string reservedSeat in reservedSeats)
            {
                string seatNumber = reservedSeat.Substring(0, 1);
                int seatRow;
                int.TryParse(seatNumber, out seatRow);
                if (seatRow == 0)
                {
                    return 0;
                }

                string seatLetter = seats.FirstOrDefault(s => string.Equals(s, reservedSeat.Substring(1, 1), StringComparison.CurrentCultureIgnoreCase));
                if (string.IsNullOrEmpty(seatLetter))
                {
                    return 0;
                }

                int seatLetterIndex = Array.IndexOf(seats, seatLetter);
                seatMap[seatRow - 1, seatLetterIndex] = reservedSeat;
            }

            int totalSeatedFamilies = 0;

            for (int k = 0; k < seatMap.GetLength(0); k++)
            {
                int counter = 0;
                for (int l = 0; l < seatMap.GetLength(1); l++)
                {
                    if (l == 0 || l == seats.Length - 1)
                    {
                        continue;
                    }

                    bool isReservedSeat = !string.IsNullOrEmpty(seatMap[k, l]);
                    if (!isReservedSeat)
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 0;
                    }

                    if (counter < 4)
                    {
                        continue;
                    }

                    totalSeatedFamilies++;
                    counter = 0;
                }
            }

            return totalSeatedFamilies;
        }
    }

}
