using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetHack
{
    public class Challenge1
    {

        public static long carParkingRoof(List<long> cars, int k)
        {
            if (cars.Count < 1 || cars.Count > Math.Pow(10, 5))
            {
                return 0;
            }

            if (k < 1 || k > cars.Count)
            {
                return 0;
            }

            long[] duplicateSpots = cars.GroupBy(c => c).Where(g => g.Count() > 1).Select(c => c.Key).ToArray();
            if (duplicateSpots.Length > 0)
            {
                return 0;
            }

            long invalidCarSpotNumber = cars.FirstOrDefault(c => c < 1 || c > Math.Pow(10, 14));
            if (invalidCarSpotNumber > 0)
            {
                return 0;
            }

            List<long> legths = new();

            long[] sortedCarSpots = cars.OrderBy(c => c).ToArray();
            int variants = cars.Count - k + 1;
            for (int i = 0; i < variants; i++)
            {
                long firstCarSpot = sortedCarSpots[i];
                long lastCarSpot = sortedCarSpots[i + k - 1];
                long length = lastCarSpot - firstCarSpot + 1;
                legths.Add(length);

            }

            return legths.Min();
        }

    }
}
