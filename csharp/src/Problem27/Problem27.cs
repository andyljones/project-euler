using System;
using System.Collections.Generic;
using System.Linq;

static class Problem27
{
    public static int CoefficientProductWithLongestPrimeSequence(int maxA, int maxB)
    {
        var tester = new PrimalityTester();

        var lengths = from a in Enumerable.Range(-maxA+1, 2*maxA-1)
                      from b in Enumerable.Range(-maxB+1, 2*maxB-1)
                      select Tuple.Create(a, b, NumberOfPrimesGeneratedByCoefficients(a, b, tester));

        var result = lengths.OrderByDescending(tuple => tuple.Item3).First();

        Console.WriteLine(String.Format("a {0}, b {1}, length {2}", result.Item1, result.Item2, result.Item3));

        return result.Item1*result.Item2;
    }

    private static int NumberOfPrimesGeneratedByCoefficients(int a, int b, PrimalityTester tester)
    {
        int lengthOfPrimeSequence = 0;
        while (tester.isPrime(evaluateQuadratic(a, b, lengthOfPrimeSequence)))
        {
            lengthOfPrimeSequence = lengthOfPrimeSequence + 1;
        }

        return lengthOfPrimeSequence;
    }

    private static int evaluateQuadratic(int a, int b, int x)
    {
        return x*x + a*x + b;
    }


}

