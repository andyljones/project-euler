using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

static class Problem26
{
    public static int LongestCycleLength(int limit)
    {
        int longest = Enumerable.Range(1, limit - 1).Select(i => FractionDigitsCycleLength(i)).Max();

        return longest;
    }

    public static int FractionDigitsCycleLength(int d)
    {
        int k = LengthOfCycle(d);

        return k;
    }

    private static int LengthOfCycle(int d)
    {
        int i = 1;
        while (true)
        {
            for (int k = 1; k <= i; k++)
            {
                int l = i - k;
                if (BigInteger.ModPow(10, i, d) == BigInteger.ModPow(10, l, d))
                {
                    return k;
                }
            }

            i++;
        }
        
        return -1;
    }
}
